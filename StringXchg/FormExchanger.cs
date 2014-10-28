using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using StringXchg.Exchanger;

namespace StringXchg
{
    public partial class FormExchanger : Form
    {
        private readonly IExchanger _exchanger = new LuaExchanger();

        public FormExchanger()
        {
            InitializeComponent();
        }

        private void textPath_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                ((TextBox) sender).Text = ((string[]) e.Data.GetData(DataFormats.FileDrop))[0];

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
                ((TextBox) sender).Text = "";
            }
        }

        private void textPath_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }

        private void buttonExport_Click(object sender, EventArgs args)
        {
            _exchanger.OneSheet = checkOneSheet.Checked;
            _exchanger.CopyTranslated = checkCopyTranslated.Checked;

            _exchanger.ExchangeToExcel(textSourceFolder.Text);
            MessageBox.Show("Completed!");
        }

        private void buttonExchange_Click(object sender, EventArgs e)
        {
            _exchanger.ExchangeToText(textExcelPath.Text, textFromFolder.Text);

            MessageBox.Show("Completed!");
        }
    }
}