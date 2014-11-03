using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using ClosedXML.Excel;
using StringXchg.Common;

namespace StringXchg.DraftHelper
{
    public class ReferenceBuilder
    {
        private readonly ILogger _logger;

        public ReferenceBuilder(ILogger logger)
        {
            _logger = logger;
        }

        public void Build(string excelPath, string srcCol, string transCol)
        {
            var dict = BuildReferences(excelPath, srcCol, transCol, true);

            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("References");
                var row = 1;
                foreach (var tuple in dict)
                {
                    worksheet.Cell(row, 1).Value = tuple.Item1;
                    worksheet.Cell(row, 2).Value = tuple.Item2;
                    row++;
                }
                var outputFile = Path.Combine(Path.GetDirectoryName(excelPath), Path.GetFileNameWithoutExtension(excelPath) + "_ref" + Path.GetExtension(excelPath));
                workbook.SaveAs(outputFile);

                _logger.ReportLog("Completed({0})", row - 1);
                _logger.ReportLog(outputFile);
            }
        }

        private static readonly Regex TokenRegex = new Regex(@"[A-Za-z0-9\-_ !@#$%^&*\(\)\[\];:'"",\./<>?~\r\n\{\}\\☆★]+", RegexOptions.Compiled);

        internal List<Tuple<string, string>> BuildReferences(string refFile, string srcCol, string transCol, bool partialOnly)
        {
            _logger.ReportLog("Build References... [{0}] ({1}/{2})", Path.GetFileName(refFile), srcCol, transCol);
            var dictMap = new Dictionary<string, string>();
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

                    if (string.IsNullOrWhiteSpace(src) || string.IsNullOrWhiteSpace(trans))
                        continue;

                    if (!partialOnly)
                        CheckAndInsertToDict(dictMap, src, trans);

                    var srcPartials = TokenRegex.Split(src);
                    var transPartials = TokenRegex.Split(trans);
                    if (srcPartials.Length != transPartials.Length)
                        continue;

                    foreach (var partialIndex in Enumerable.Range(0, srcPartials.Length))
                        CheckAndInsertToDict(dictMap, srcPartials[partialIndex], transPartials[partialIndex]);
                }
            }

            var dict = dictMap.Select(e => Tuple.Create(e.Key, e.Value)).ToList();

            dict.Sort((left, right) => right.Item1.Length - left.Item1.Length);
            _logger.ReportLog("Find References ({0})", dict.Count);
            return dict;
        }

        private static void CheckAndInsertToDict(Dictionary<string, string> dictMap, string src, string trans)
        {
            if (string.IsNullOrWhiteSpace(src) || string.IsNullOrWhiteSpace(trans))
                return;

            if (!dictMap.ContainsKey(src))
                dictMap.Add(src, trans);
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

    }
}
