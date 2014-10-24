using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LuaStringXchg
{
    public partial class FormExchanger : Form
    {
        public FormExchanger()
        {
            InitializeComponent();
        }

        private void textPath_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                ((TextBox)sender).Text = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];

                if (sender == textFromFolder)
                {
                    if (Directory.Exists(textFromFolder.Text))
                    {
                        textExcelPath.Text = Directory.GetFiles(textFromFolder.Text, "*.xlsx").FirstOrDefault()
                            ?? Directory.GetFiles(textFromFolder.Text, "*.xls").FirstOrDefault()
                            ?? string.Empty;
                    }
                }
            }
            catch
            {
                ((TextBox)sender).Text = "";
            }
        }

        private void textPath_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }

        private static readonly Regex stringRegex = new Regex("\"([^\"]+)\"", RegexOptions.Compiled);
        private static readonly Regex idRegex = new Regex("#([^#]+)#", RegexOptions.Compiled);
        private static readonly Encoding utf8 = new UTF8Encoding(false);

        private void buttonExport_Click(object sender, EventArgs args)
        {
            var outputPath = Path.Combine(Path.GetDirectoryName(textSourceFolder.Text), Path.GetFileNameWithoutExtension(textSourceFolder.Text) + "_out");
            if (!Directory.Exists(outputPath))
                Directory.CreateDirectory(outputPath);

            var workbook = new XLWorkbook();
            var oneSheet = checkOneSheet.Checked ? workbook.Worksheets.Add("forL10N") : null;
            var row = 1;
            foreach (var file in Directory.GetFiles(textSourceFolder.Text, "*.lua", SearchOption.AllDirectories))
            {
                var fileName = Path.GetFileNameWithoutExtension(file);
                var index = 1;

                if (!checkOneSheet.Checked)
                    row = 1;
                
                var worksheet = checkOneSheet.Checked ? oneSheet : workbook.Worksheets.Add(fileName);
                var lines = new List<string>();
                foreach (var line in File.ReadAllLines(file, utf8))
                {
                    var replaced = line;
                    if (replaced.Contains("--") && (!replaced.Contains("[[") && !replaced.Contains("]]")))
                    {
                        var comment = replaced.Substring(replaced.IndexOf("--") + 2);
                        if (comment.Any(e => (int)e < 0 || (int)e >= 128))
                        {
                            var id = string.Format("{0}:{1:D4}", fileName, index);
                            var text = comment;

                            worksheet.Cell(row, 1).Value = id;
                            worksheet.Cell(row, 2).Value = text;

                            if (checkCopyTranslated.Checked)
                                worksheet.Cell(row, 3).Value = text;

                            replaced = replaced.Substring(0, replaced.IndexOf("--") + 2) + "#" + id + "#";

                            ++index;
                            ++row;
                        }
                    }
                    replaced = stringRegex.Replace(replaced, match =>
                    {
                        var id = string.Format("{0}:{1:D4}", fileName, index);
                        var text = match.Groups[1].Value;

                        if (text.Any(e => (int)e < 0 || (int)e >= 128))
                        {
                            worksheet.Cell(row, 1).Value = id;
                            worksheet.Cell(row, 2).Value = text;

                            if (checkCopyTranslated.Checked)
                                worksheet.Cell(row, 3).Value = text;

                            ++index;
                            ++row;
                            return "#" + id + "#";
                        }
                        return text;
                    });
                    lines.Add(replaced);
                }
                File.WriteAllLines(Path.Combine(outputPath, Path.GetFileName(file)), lines.ToArray(), utf8);

            }
            workbook.SaveAs(Path.Combine(outputPath, Path.GetFileNameWithoutExtension(textSourceFolder.Text) + ".xlsx"));

            MessageBox.Show("Completed!");
            Process.Start("explorer.exe", outputPath);
        }

        private void buttonExchange_Click(object sender, EventArgs e)
        {
            var stringMap = new Dictionary<string, string>();
            using (var workbook = new XLWorkbook(textExcelPath.Text))
            {
                foreach (var worksheet in workbook.Worksheets)
                {
                    for (var row = 1; ; ++row)
                    {
                        var id = worksheet.Cell(row, 1).Value;
                        if (id == null) break;
                        if (string.IsNullOrWhiteSpace(id.ToString())) break;

                        var text = worksheet.Cell(row, 3).Value;
                        stringMap.Add(id.ToString(), text != null ? text.ToString() : "");
                    }
                }
            }

            var outputPath = Path.Combine(Path.GetDirectoryName(textFromFolder.Text), Path.GetFileNameWithoutExtension(textFromFolder.Text) + "_out");
            if (!Directory.Exists(outputPath))
                Directory.CreateDirectory(outputPath);

            foreach (var file in Directory.GetFiles(textFromFolder.Text, "*.lua", SearchOption.AllDirectories))
            {
                var fileName = Path.GetFileNameWithoutExtension(file);
                var index = 1;

                var lines = new List<string>();
                foreach (var line in File.ReadAllLines(file, utf8))
                {
                    lines.Add(idRegex.Replace(line, match =>
                    {
                        var id = match.Groups[1].Value;
                        var text = id;
                        stringMap.TryGetValue(id, out text);

                        ++index;
                        if (line.IndexOf(id) > 2 && line[line.IndexOf(id) - 2] == '-')
                            return text;
                        return "\"" + text + "\"";
                    }));
                }
                File.WriteAllLines(Path.Combine(outputPath, Path.GetFileName(file)), lines.ToArray(), utf8);
            }

            MessageBox.Show("Completed!");
            Process.Start("explorer.exe", outputPath);
        }
    }
}
