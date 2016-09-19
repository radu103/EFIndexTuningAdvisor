using EFIndexTuningAdvisor;
using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using WideWorldImportersDomain;

namespace EFIndexTuningAdvisorTestApp
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void testAdventureWorks_Click(object sender, EventArgs e)
        {
            missingIndexesTreeView.Nodes.Clear();
            frequentQueriesListView.Items.Clear();
            timeConsumingQueriesListView.Items.Clear();
            slowestQueriesListView.Items.Clear();

            tableLayoutPanel1.Enabled = false;

            RunTestQuesriesBackgroundWorker.RunWorkerAsync();
        }

        private void seeCapturedQueriesbutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To Do...");
        }

        private void RunTestQuesriesBackgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            var ctx = new WideWorldImporters();

            // start capture
            ctx.StartCaptureSQLSelects();

            //querys
            TestContextOperations.doQueries(ctx);

            // stop capture
            ctx.StopCaptureSQLSelects();

            // analytics on query cached
            var indexes = ctx.GetIndexAdviceList();
            var topf = ctx.GetTopFrequentQueries();
            var topslow = ctx.GetTopSlowestQueries();
            var toptime = ctx.GetTopTimeConsumingQueries();

            e.Result = new TestResultsForDisplay
            {
                IndexSuggestions = indexes,
                TopFrequentQueries = topf,
                TopSlowestQueries = topslow,
                TopTimeConsumingQueries = toptime
            };
        }

        private void RunTestQuesriesBackgroundWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            tableLayoutPanel1.Enabled = true;

            if (e.Result != null)
            {
                var suggestions = (TestResultsForDisplay)e.Result;

                // frequent queries
                foreach (var q in suggestions.TopFrequentQueries)
                {
                    var item = frequentQueriesListView.Items.Add(q.sql);
                    item.Tag = q;
                    item.SubItems.Add(q.repeat_count.ToString());
                    item.ToolTipText = q.sql;
                }

                // most time queries
                foreach (var q in suggestions.TopTimeConsumingQueries)
                {
                    var item = timeConsumingQueriesListView.Items.Add(q.sql);
                    item.Tag = q;
                    item.SubItems.Add(q.total_time_in_ms.ToString("0"));
                    item.ToolTipText = q.sql;
                }

                // slowest queries
                foreach (var q in suggestions.TopSlowestQueries)
                {
                    var item = slowestQueriesListView.Items.Add(q.sql);
                    item.Tag = q;
                    item.SubItems.Add(q.time_in_ms.ToString("0.00"));
                    item.ToolTipText = q.sql;
                }
            }
        }
    }
}