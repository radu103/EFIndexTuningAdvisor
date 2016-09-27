using EFIndexTuningAdvisor;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace EFIndexTuningAdvisorTestApp
{
    public partial class CapturedQueriesForm : Form
    {
        public CapturedQueriesForm()
        {
            InitializeComponent();
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            var saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "TXT File|*.txt";
            saveFileDialog1.Title = "Save an TXT File";
            saveFileDialog1.ShowDialog();

            // If the file name is not an empty string open it for saving.
            if (saveFileDialog1.FileName != "" && EFSelectQueryCache.QueryLog.Count > 0)
            {
                exportWorker.RunWorkerAsync(saveFileDialog1.FileName);
            }
        }

        private void exportWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            try
            {
                var fileName = e.Argument.ToString();
                File.WriteAllLines(fileName, EFSelectQueryCache.QueryLog.Select(q => q.ToString()));
                e.Result = true;
            }
            catch (Exception err)
            {
                e.Result = false;
                MessageBox.Show(err.Message);
                MessageBox.Show(err.StackTrace);
            }
        }

        private void exportWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (Convert.ToBoolean(e.Result) == true)
            {
                MessageBox.Show("Export to file ready !");
            }
        }

        private void CapturedQueriesForm_Load(object sender, EventArgs e)
        {
            dataGridView.DataSource = EFSelectQueryCache.QueryLog;
        }
    }
}