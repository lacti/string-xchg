namespace StringXchg.Exchanger
{
    internal interface IExchanger
    {
        bool OneSheet { set; }
        bool CopyTranslated { set; }

        string ExchangeToExcel(string sourceFolder);
        string ExchangeToText(string excelPath, string fromFolder);
    }
}