using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using ClosedXML.Excel;
using StringXchg.Common;

namespace StringXchg.DraftHelper
{
    public class AutoSubstitutor
    {
        private readonly ILogger _logger;
        private readonly ReferenceBuilder _refBuilder;

        public AutoSubstitutor(ILogger logger)
        {
            _logger = logger;
            _refBuilder = new ReferenceBuilder(logger);
        }

        public void Execute(string refPath, string refSCol, string refTCol, string targetPath, string targetSCol, string targetTCol)
        {
            try
            {
                var dict = _refBuilder.BuildReferences(refPath, refSCol, refTCol, false);
                Substitute(targetPath, targetSCol, targetTCol, dict);
            }
            catch (Exception e)
            {
                _logger.ReportLog(e);
            }
        }


        private void Substitute(string targetFile, string srcCol, string transCol, List<Tuple<string, string>> dict)
        {
            _logger.ReportLog("Start substitution [{0}] ({1}/{2})", Path.GetFileName(targetFile), srcCol, transCol);
            var backupFile = BackupFile(targetFile);
            _logger.ReportLog("Backup old file to [{0}]", Path.GetFileName(backupFile));

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

                    _logger.ReportLog(".. substituted '{0}' -> '{1}'", trans, substituted);
                    SetValueSafe(worksheet, row, transCol, ApplySubstitution(dict, src));

                    ++substitutedCount;
                }

                workbook.Save();
            }
            _logger.ReportLog("Substitution completed [{0}], total: {1}", Path.GetFileName(targetFile), substitutedCount);
        }

        private string ApplySubstitution(IEnumerable<Tuple<string, string>> dict, string trans)
        {
            return dict.Aggregate(trans, (current, tuple) => current.Replace(tuple.Item1, tuple.Item2));
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
                _logger.ReportLog(e, "cannot get cell value({0}, {1})", row, col);
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
                _logger.ReportLog(e, "cannot set cell value({0}, {1}) to '{2}'", row, col, newValue);
            }
        }

        private string BackupFile(string filePath)
        {
            var backupFile = Path.Combine(Path.GetDirectoryName(filePath)
                                           , Path.GetFileNameWithoutExtension(filePath) + "_" + DateTime.Now.ToString("yyyyMMddHHmmss") + Path.GetExtension(filePath));
            File.Copy(filePath, backupFile);
            return backupFile;
        }


    }
}
