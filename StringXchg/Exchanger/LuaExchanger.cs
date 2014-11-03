using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using ClosedXML.Excel;

namespace StringXchg.Exchanger
{
    internal class LuaExchanger : AbstractExchanger
    {
        private static readonly Regex StringRegex = new Regex("\"([^\"]*)\"", RegexOptions.Compiled);
        private static readonly Encoding Utf8 = new UTF8Encoding(false);

        private int _index;
        private int _row;

        private void ResetContext()
        {
            _index = 1;
            _row = 1;
        }

        public override string ExchangeToExcel(string sourceFolder)
        {
            ResetContext();

            var outputPath = GetOutputPath(sourceFolder);
            EnsurePath(outputPath);

            var workbook = new XLWorkbook();
            var oneSheet = OneSheet ? workbook.Worksheets.Add("forL10N") : null;
            foreach (var file in Directory.GetFiles(sourceFolder, "*.lua", SearchOption.AllDirectories))
            {
                var fileName = Path.GetFileNameWithoutExtension(file);
                _index = 1;

                if (!OneSheet)
                    _row = 1;

                var worksheet = OneSheet ? oneSheet : workbook.Worksheets.Add(fileName);
                var lines = new List<string>();
                foreach (var line in File.ReadAllLines(file, Utf8))
                {
                    var replaced = line;
                    if (IsLuaComment(replaced))
                    {
                        var comment = ExtractStringFromComment(replaced);
                        if (comment.Any(IsNotAscii))
                        {
                            var id = MakeStringId(fileName);
                            var text = comment;

                            SetValueToWorksheet(worksheet, id, text);
                            replaced = ExtractStringBeforeComment(replaced) + ToStringId(id);

                            NextIndex();
                        }
                    }
                    replaced = StringRegex.Replace(replaced, match =>
                    {
                        var text = match.Groups[1].Value;

                        if (!text.Any(IsNotAscii))
                            return ToQuote(text);
                        var id = MakeStringId(fileName);
                        SetValueToWorksheet(worksheet, id, text);

                        NextIndex();
                        return ToStringId(id);
                    });
                    lines.Add(replaced);
                }
                File.WriteAllLines(Path.Combine(outputPath, Path.GetFileName(file)), lines.ToArray(), Utf8);
            }

            var excelPath = Path.Combine(outputPath, Path.GetFileNameWithoutExtension(sourceFolder) + ".xlsx");
            workbook.SaveAs(excelPath);

            return excelPath;
        }

        private void NextIndex()
        {
            ++_index;
            ++_row;
        }

        private static string ExtractStringFromComment(string replaced)
        {
            return replaced.Substring(replaced.IndexOf("--") + 2);
        }

        private static string ExtractStringBeforeComment(string comment)
        {
            return comment.Substring(0, comment.IndexOf("--") + 2);
        }

        private static bool IsLuaComment(string replaced)
        {
            return replaced.Contains("--") && (!replaced.Contains("[[") && !replaced.Contains("]]"));
        }

        private string MakeStringId(string fileName)
        {
            return string.Format("{0}:{1:D4}", fileName, _index);
        }

        private void SetValueToWorksheet(IXLWorksheet worksheet, string id, string text)
        {
            worksheet.Cell(_row, 1).Value = id;
            worksheet.Cell(_row, 2).Value = text;

            if (CopyTranslated)
                worksheet.Cell(_row, 3).Value = text;
        }

        public override string ExchangeToText(string excelPath, string fromFolder)
        {
            var stringMap = new Dictionary<string, string>();
            using (var workbook = new XLWorkbook(excelPath))
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

            var outputPath = GetOutputPath(fromFolder);
            EnsurePath(outputPath);

            foreach (var file in Directory.GetFiles(fromFolder, "*.lua", SearchOption.AllDirectories))
            {
                File.WriteAllLines(Path.Combine(outputPath, Path.GetFileName(file)), File.ReadAllLines(file, Utf8).Select(
                    line => IdRegex.Replace(line, match =>
                    {
                        var id = match.Groups[1].Value;
                        string text;
                        if (!stringMap.TryGetValue(id, out text))
                            text = id;

                        return CheckIfCommentString(line, id) ? text : ToQuote(text);
                    })).ToArray(), Utf8);
            }

            return outputPath;
        }

        private static bool CheckIfCommentString(string replaced, string id)
        {
            var idIndex = replaced.IndexOf(id);
            return idIndex > 2 && replaced[idIndex - 2] == '-';
        }
    }
}