using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DraftHelper
{
    public partial class FormDraftHelper : Form
    {
        public FormDraftHelper()
        {
            InitializeComponent();
        }

        private void backgroundSubstitutor_DoWork(object sender, DoWorkEventArgs args)
        {
            try
            {
                var dict = BuildReferences(textRefPath.Text, textRefSCol.Text, textRefTCol.Text);
                Substitute(textTargetPath.Text, textTargetSCol.Text, textTargetTCol.Text, dict);
            }
            catch (Exception e)
            {
                ReportLog(e);
            }
        }

        private List<Tuple<string, string>> BuildReferences(string refFile, string srcCol, string transCol)
        {
            ReportLog("Build References... [{0}] ({1}/{2})", Path.GetFileName(refFile), srcCol, transCol);
            var dict = new List<Tuple<string, string>>();
            using (var workbook = new XLWorkbook(refFile))
            {
                var worksheet = workbook.Worksheets.FirstOrDefault();
                if (worksheet == null)
                    throw new Exception("cannot find any worksheet in a reference excel file");

                var firstRow = worksheet.FirstRowUsed().RowNumber();
                var lastRow = worksheet.LastRowUsed().RowNumber();
                foreach (var row in Enumerable.Range(firstRow, lastRow - firstRow + 1))
                {
                    var src = GetValueSafe(worksheet, row, srcCol);
                    var trans = GetValueSafe(worksheet, row, transCol);

                    if (!string.IsNullOrWhiteSpace(src) && !string.IsNullOrWhiteSpace(trans))
                        dict.Add(Tuple.Create(src, trans));
                }
            }
            dict.Sort(new Comparison<Tuple<string, string>>((left, right) => right.Item1.Length - left.Item1.Length));
            ReportLog("Find References ({0})", dict.Count);
            return dict;
        }

        private void Substitute(string targetFile, string srcCol, string transCol, List<Tuple<string, string>> dict)
        {
            ReportLog("Start substitution [{0}] ({1}/{2})", Path.GetFileName(targetFile), srcCol, transCol);
            var backupFile = BackupFile(targetFile);
            ReportLog("Backup old file to [{0}]", Path.GetFileName(backupFile));

            var substitutedCount = 0;
            using (var workbook = new XLWorkbook(targetFile))
            {
                var worksheet = workbook.Worksheets.FirstOrDefault();
                if (worksheet == null)
                    throw new Exception("cannot find any worksheet in a reference excel file");

                var firstRow = worksheet.FirstRowUsed().RowNumber();
                var lastRow = worksheet.LastRowUsed().RowNumber();
                foreach (var row in Enumerable.Range(firstRow, lastRow - firstRow + 1))
                {
                    var src = GetValueSafe(worksheet, row, srcCol);
                    var trans = GetValueSafe(worksheet, row, transCol);

                    if (string.IsNullOrWhiteSpace(src))
                        continue;

                    var substituted = string.IsNullOrWhiteSpace(trans)
                        ? ApplySubstitution(dict, src)
                        : ApplySubstitution(dict, trans);

                    if (string.Equals(trans, substituted))
                        continue;

                    ReportLog(".. substituted '{0}' -> '{1}'", trans, substituted);
                    SetValueSafe(worksheet, row, transCol, ApplySubstitution(dict, src));

                    ++substitutedCount;
                }

                workbook.Save();
            }
            ReportLog("Substitution completed [{0}], total: {1}", Path.GetFileName(targetFile), substitutedCount);
        }

        private string ApplySubstitution(List<Tuple<string, string>> dict, string trans)
        {
            var result = trans;
            foreach (var tuple in dict)
            {
                result = result.Replace(tuple.Item1, tuple.Item2);
            }
            return result;
        }

        private string GetValueSafe(IXLWorksheet worksheet, int row, string col)
        {
            try
            {
                if (worksheet == null) return string.Empty;

                var cell = worksheet.Cell(row, col);
                if (cell == null) return string.Empty;
                if (cell.Value == null) return string.Empty;
                return cell.Value.ToString();
            }
            catch (Exception e)
            {
                ReportLog(e, "cannot get cell value({0}, {1})", row, col);
            }
            return string.Empty;
        }

        private void SetValueSafe(IXLWorksheet worksheet, int row, string col, string newValue)
        {
            try
            {
                if (worksheet == null) return;

                var cell = worksheet.Cell(row, col);
                if (cell == null) return;
                cell.Value = newValue;
            }
            catch (Exception e)
            {
                ReportLog(e, "cannot set cell value({0}, {1}) to '{2}'", row, col, newValue);
            }
        }

        private string BackupFile(string filePath)
        {
            var backupFile = Path.Combine(Path.GetDirectoryName(filePath)
                                           , Path.GetFileNameWithoutExtension(filePath) + "_" + DateTime.Now.ToString("yyyyMMddHHmmss") + Path.GetExtension(filePath));
            File.Copy(filePath, backupFile);
            return backupFile;
        }

        private void backgroundSubstitutor_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            groupRef.Enabled = true;
            groupTarget.Enabled = true;
            buttonSubstitution.Enabled = true;
        }

        private void buttonSubstitution_Click(object sender, EventArgs e)
        {
            if (backgroundSubstitutor.IsBusy)
                return;

            groupRef.Enabled = false;
            groupTarget.Enabled = false;
            buttonSubstitution.Enabled = false;

            textLog.Clear();

            backgroundSubstitutor.RunWorkerAsync();
        }

        private void buttonRefPathFinder_Click(object sender, EventArgs e)
        {
            var browser = new OpenFileDialog
            {
                Title = "Find a reference file",
                Filter = "Excel Files|*.xlsx|Excel Files|*.xls|All Files|*.*"
            };
            if (browser.ShowDialog(this) == DialogResult.OK)
            {
                textRefPath.Text = browser.FileName;
            }
        }

        private void buttonTargetPathFinder_Click(object sender, EventArgs e)
        {
            var browser = new OpenFileDialog
            {
                Title = "Find a reference file",
                Filter = "Excel Files|*.xlsx|Excel Files|*.xls|All Files|*.*"
            };
            if (browser.ShowDialog(this) == DialogResult.OK)
            {
                textTargetPath.Text = browser.FileName;
            }
        }

        #region Logger

        private void ReportLog(Exception e, string logFormat, params object[] args)
        {
            ReportLog(logFormat, args);
            ReportLog(e);
        }

        private void ReportLog(Exception e)
        {
            ReportLog(e.Message);
            ReportLog(e.StackTrace);
            if (e.InnerException != null)
                ReportLog(e.InnerException);
        }

        private void ReportLog(string logFormat, params object[] args)
        {
            var log = args != null && args.Length > 0 ? string.Format(logFormat, args) : logFormat;
            ReportLogInternal(string.Format("[{0}] {1}", DateTime.Now.ToString("MM.dd HH:mm:ss"), log));
        }

        private void ReportLogInternal(string log)
        {
            if (InvokeRequired) Invoke(new MethodInvoker(() => ReportLogInternal(log)));
            else textLog.AppendText(log + Environment.NewLine);
        }

        #endregion
    }
}
