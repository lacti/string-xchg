using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringXchg.Common
{
    public interface ILogger
    {
        void ReportLog(Exception e, string logFormat, params object[] args);

        void ReportLog(Exception e);

        void ReportLog(string logFormat, params object[] args);
    }
}
