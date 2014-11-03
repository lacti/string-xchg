using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using StringXchg.Common;
using StringXchg.DraftHelper;
using StringXchg.Exchanger;

namespace StringXchg
{
    public partial class FormTools : Form, ILogger
    {
        private readonly IExchanger _exchanger;
        private readonly AutoSubstitutor _substitutor;
        private readonly ReferenceBuilder _refBuilder;

        public FormTools()
        {
            InitializeComponent();

            _exchanger = new LuaExchanger(this);
            _substitutor = new AutoSubstitutor(this);
            _refBuilder = new ReferenceBuilder(this);
        }

        private void SafeExecute(Action action)
        {
            try
            {
                action();
            }
            catch (Exception e)
            {
                ReportLog(e);
            }
        }

        private void AsyncExecute(Action action, Action afterCompletion)
        {
            Task.Factory.StartNew(() => SafeExecute(action)).ContinueWith(_ => afterCompletion(), TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void buttonExport_Click(object sender, EventArgs args)
        {
            textLog.Clear();

            _exchanger.OneSheet = checkOneSheet.Checked;
            _exchanger.CopyTranslated = checkCopyTranslated.Checked;

            buttonExport.Enabled = false;
            AsyncExecute(() => _exchanger.ExchangeToExcel(textSourceFolder.Text), () => { buttonExport.Enabled = true; });
        }

        private void buttonExchange_Click(object sender, EventArgs e)
        {
            textLog.Clear();

            buttonExchange.Enabled = false;
            AsyncExecute(() => _exchanger.ExchangeToText(textExcelPath.Text, textFromFolder.Text), () => { buttonExchange.Enabled = true; });
        }

        private void FormExchanger_Load(object sender, EventArgs e)
        {
#if DEBUG
            var args = Environment.GetCommandLineArgs();
            if (args.Length == 2)
            {
                _exchanger.OneSheet = true;
                _exchanger.CopyTranslated = true;
                _exchanger.ExchangeToExcel(args[1]);
                Close();
            }
            else if (args.Length == 3)
            {
                _exchanger.ExchangeToText(args[2], args[1]);
                Close();
            }
#endif
        }
        #region Logger

        public void ReportLog(Exception e, string logFormat, params object[] args)
        {
            ReportLog(logFormat, args);
            ReportLog(e);
        }

        public void ReportLog(Exception e)
        {
            for (var exception = e; exception != null; exception = exception.InnerException)
            {
                ReportLog(exception.Message);
                ReportLog(exception.StackTrace);
            }
        }

        public void ReportLog(string logFormat, params object[] args)
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

        #region Browse

        private string BrowseExcelFile()
        {
            var browser = new OpenFileDialog
            {
                Title = "Find a excel file",
                Filter = "Excel Files|*.xlsx|Excel Files|*.xls|All Files|*.*"
            };
            if (browser.ShowDialog(this) == DialogResult.OK)
            {
                return browser.FileName;
            }
            return string.Empty;
        }

        private string BrowseFolder(string description)
        {
            var browser = new FolderBrowserDialog
            {
                Description =  description
            };
            if (browser.ShowDialog(this) == DialogResult.OK)
            {
                return browser.SelectedPath;
            }
            return string.Empty;
        }

        #endregion

        private void buttonSourceFolderBrowse_Click(object sender, EventArgs e)
        {
            textSourceFolder.Text = BrowseFolder("Choose a folder that contains lua files.");
        }

        private void buttonFromFolderBrowse_Click(object sender, EventArgs e)
        {
            textFromFolder.Text = BrowseFolder("Choose a folder that contains lua files.");
        }

        private void buttonExcelPathBrowse_Click(object sender, EventArgs e)
        {
            textExcelPath.Text = BrowseExcelFile();
        }

        private void buttonRefPathFinder_Click(object sender, EventArgs e)
        {
            textRefPath.Text = BrowseExcelFile();
        }

        private void buttonTargetPathFinder_Click(object sender, EventArgs e)
        {
            textTargetPath.Text = BrowseExcelFile();
        }

        private void buttonSubstitution_Click(object sender, EventArgs args)
        {
            textLog.Clear();
            buttonSubstitution.Enabled = false;
            AsyncExecute(() => _substitutor.Execute(textRefPath.Text, textRefSCol.Text, textRefTCol.Text, textTargetPath.Text, textTargetSCol.Text, textTargetTCol.Text),
                () => { buttonSubstitution.Enabled = true; });
        }

        private void buttonBuildSourcePathBrowse_Click(object sender, EventArgs e)
        {
            textBuildSourcePath.Text = BrowseExcelFile();
        }

        private void buttonBuildReference_Click(object sender, EventArgs e)
        {
            textLog.Clear();
            buttonBuildReference.Enabled = false;
            AsyncExecute(() => _refBuilder.Build(textBuildSourcePath.Text, textBuildRefSCol.Text, textBuildRefTCol.Text),
                () => { buttonBuildReference.Enabled = true; });
        }
    }
}