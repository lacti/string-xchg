using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ClosedXML.Excel;

namespace ExcelFinder
{
    public partial class FormFinder : Form
    {
        public FormFinder()
        {
            InitializeComponent();
        }

        private void buttonFindFolder_Click(object sender, EventArgs e)
        {
            var chooser = new FolderBrowserDialog {Description = "Select a path for searching"};
            if (chooser.ShowDialog(this) == DialogResult.OK)
            {
                listPaths.Items.Add(chooser.SelectedPath);
            }
        }

        private void buttonRemoveFolder_Click(object sender, EventArgs e)
        {
            if (listPaths.SelectedIndex >= 0)
            {
                listPaths.Items.RemoveAt(listPaths.SelectedIndex);
            }
        }

        private void listPaths_DragDrop(object sender, DragEventArgs e)
        {
            var paths = (string[]) e.Data.GetData(DataFormats.FileDrop);
            foreach (var path in paths)
            {
                if (Directory.Exists(path) || File.Exists(path))
                {
                    listPaths.Items.Add(path);
                }
            }
        }

        private void listPaths_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }

        private void listPaths_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                buttonRemoveFolder_Click(sender, e);
            }
        }

        private void textKeyword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonSearch_Click(sender, e);
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (backgroundFinder.IsBusy)
                return;

            buttonSearch.Enabled = false;
            textKeyword.Enabled = false;
            listResult.Items.Clear();

            backgroundFinder.RunWorkerAsync();
        }

        private void backgroundFinder_DoWork(object sender, DoWorkEventArgs e)
        {
            UpdateStatus("Preparing files...");

            var excelFiles = new List<string>();
            foreach (string path in listPaths.Items)
            {
                if (File.Exists(path)) excelFiles.Add(path);
                else if (Directory.Exists(path))
                {
                    excelFiles.AddRange(FindFiles(path, "*.xls"));
                    excelFiles.AddRange(FindFiles(path, "*.xlsx"));
                }
            }
            excelFiles = excelFiles.Distinct().ToList();
            excelFiles.Sort();

            var keyword = textKeyword.Text.Trim();
            if (string.IsNullOrWhiteSpace(keyword))
                return;

            foreach (var excelFile in excelFiles)
            {
                UpdateStatus("Search at " + Path.GetFileName(excelFile));
                try
                {
                    Search(excelFile, keyword);
                }
                catch
                {
                }
            }
        }

        private void Search(string excelFile, string keyword)
        {
            using (var workbook = new XLWorkbook(excelFile))
            {
                foreach (var worksheet in workbook.Worksheets)
                {
                    var range = worksheet.RangeUsed();
                    if (range == null)
                        continue;

                    for (var row = 1; row <= range.RowCount(); ++row)
                    {
                        for (var column = 1; column <= range.ColumnCount(); ++column)
                        {
                            var cell = range.Cell(row, column);
                            if (cell == null)
                                continue;

                            try
                            {
                                var value = cell.GetValue<string>();
                                if (string.IsNullOrWhiteSpace(value))
                                    continue;

                                if (value.Contains(keyword))
                                {
                                    AddResult(excelFile, worksheet.Name, cell.Address.ToString(), value);
                                }
                            }
                            catch
                            {
                            }
                        }
                    }
                }
            }
        }

        private void UpdateStatus(string message)
        {
            if (InvokeRequired) Invoke(new MethodInvoker(() => UpdateStatus(message)));
            else labelStatus.Text = message;
        }

        private void AddResult(string filePath, string sheet, string address, string text)
        {
            if (InvokeRequired) Invoke(new MethodInvoker(() => AddResult(filePath, sheet, address, text)));
            else listResult.Items.Add(new ListViewItem(new[] {filePath, sheet, address, text}));
        }

        private void backgroundFinder_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
        }

        private void backgroundFinder_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            buttonSearch.Enabled = true;
            textKeyword.Enabled = true;
            labelStatus.Text = "Wait";

            textKeyword.Focus();
        }

        private string[] FindFiles(string dir, string pattern)
        {
            try
            {
                return Directory.GetFiles(dir, pattern, SearchOption.AllDirectories);
            }
            catch
            {
                var files = new List<string>();
                try
                {
                    files.AddRange(Directory.GetFiles(dir, pattern, SearchOption.TopDirectoryOnly));
                }
                catch
                {
                }
                try
                {
                    foreach (var subDir in Directory.GetDirectories(dir))
                    {
                        files.AddRange(FindFiles(subDir, pattern));
                    }
                }
                catch
                {
                }
                return files.ToArray();
            }
        }

        private void listResult_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                var items = listResult.SelectedItems[0].SubItems;
                var excelPath = items[0].Text;
                Process.Start("excel.exe", excelPath);
            }
            catch
            {
            }
        }

        private void listResult_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C)
            {
                var copyData = string.Join(Environment.NewLine, listResult.SelectedItems.OfType<ListViewItem>()
                    .Select(item => string.Join(",", item.SubItems.OfType<ListViewItem.ListViewSubItem>()
                    .Select(subItem => subItem.Text))));

                Clipboard.SetText(copyData);
            }
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            var chooser = new SaveFileDialog
            {
                Title =  "Export result to excel",
                Filter = "Excel Files|*.xlsx"
            };
            if (chooser.ShowDialog(this) != DialogResult.OK)
                return;

            var resultFile = "";
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Result");
                var row = 1;
                foreach (ListViewItem item in listResult.Items)
                {
                    var excelPath = item.SubItems[0].Text;
                    var sheetName = item.SubItems[1].Text;
                    var address = item.SubItems[2].Text;
                    var text = item.SubItems[3].Text;

                    worksheet.Cell(row, 1).FormulaA1 =  string.Format("HYPERLINK(\"[{0}]{1}!{2}\", \"{0}\")", excelPath, sheetName, address);
                    worksheet.Cell(row, 2).Value = sheetName;
                    worksheet.Cell(row, 3).Value = address;
                    worksheet.Cell(row, 4).Value = text;
                    ++row;
                }
                worksheet.Columns().AdjustToContents();

                resultFile = chooser.FileName;
                if (File.Exists(resultFile))
                    File.Delete(resultFile);

                workbook.SaveAs(chooser.FileName);
            }

            if (!string.IsNullOrWhiteSpace(resultFile) && File.Exists(resultFile))
            {
                Process.Start("excel.exe", resultFile);
            }
        }
    }
}