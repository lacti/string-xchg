using System.IO;
using System.Text.RegularExpressions;
using StringXchg.Common;

namespace StringXchg.Exchanger
{
    internal abstract class AbstractExchanger : IExchanger
    {
        protected static readonly Regex IdRegex = new Regex("#([^#]+)#", RegexOptions.Compiled);

        protected readonly ILogger Logger;

        protected AbstractExchanger(ILogger logger)
        {
            Logger = logger;
        }

        public bool OneSheet { protected get; set; }
        public bool CopyTranslated { protected get; set; }

        public abstract string ExchangeToExcel(string sourceFolder);
        public abstract string ExchangeToText(string excelPath, string fromFolder);

        protected static string GetOutputPath(string path)
        {
            return Path.Combine(Path.GetDirectoryName(path), Path.GetFileNameWithoutExtension(path) + "_out");
        }

        protected static void EnsurePath(string path)
        {
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
        }

        protected static bool IsNotAscii(char ch)
        {
            return ch < 0 || ch > 127;
        }

        protected static string ToStringId(string id)
        {
            return "#" + id + "#";
        }

        protected static string ToQuote(string value)
        {
            return "\"" + value + "\"";
        }
    }
}