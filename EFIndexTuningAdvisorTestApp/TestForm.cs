﻿using EFIndexTuningAdvisor;
using System;
using System.Collections.Generic;
using System.IO;
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

            RunTestQueriesBackgroundWorker.RunWorkerAsync();
        }

        private void seeCapturedQueriesbutton_Click(object sender, EventArgs e)
        {
            var form = new CapturedQueriesForm();
            form.ShowDialog();
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

                missingIndexesTreeView.Tag = suggestions.IndexSuggestions;
                frequentQueriesListView.Tag = suggestions.TopFrequentQueries;
                timeConsumingQueriesListView.Tag = suggestions.TopTimeConsumingQueries;
                slowestQueriesListView.Tag = suggestions.TopSlowestQueries;

                // index suggestions
                foreach (var q in suggestions.IndexSuggestions)
                {
                    if (q.IndexesNeeded.Count > 0)
                    {
                        var node = missingIndexesTreeView.Nodes.Add(q.Query);
                        node.Tag = q;
                        node.ToolTipText = q.Query;

                        foreach (string idx_adv in q.IndexesNeeded)
                        {
                            var inode = node.Nodes.Add(idx_adv);
                            inode.Tag = idx_adv;
                            inode.ToolTipText = idx_adv;
                        }
                    }
                }

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
                    item.SubItems.Add(q.avg_time_in_ms.ToString("0.00"));
                    item.ToolTipText = q.sql;
                }
            }
        }

        private void exportSQLForIndexCreationButton_Click(object sender, EventArgs e)
        {
            var saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "SQL File|*.sql";
            saveFileDialog1.Title = "Save an SQL File";
            saveFileDialog1.ShowDialog();

            // If the file name is not an empty string open it for saving.
            if (saveFileDialog1.FileName != "" && missingIndexesTreeView.Tag != null)
            {
                var list = missingIndexesTreeView.Tag as List<EFQueryIndexAdvice>;

                var all_idx = new List<string>();
                foreach (EFQueryIndexAdvice adv in list)
                {
                    foreach (string idx in adv.IndexesNeeded)
                    {
                        if (all_idx.IndexOf(idx) < 0)
                            all_idx.Add(idx);
                    }
                }

                File.WriteAllLines(saveFileDialog1.FileName, all_idx);
            }
        }

        private void exportTimeConsumingQueries_Click(object sender, EventArgs e)
        {
            var saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "TXT File|*.txt";
            saveFileDialog1.Title = "Save an Text File";
            saveFileDialog1.ShowDialog();

            // If the file name is not an empty string open it for saving.
            if (saveFileDialog1.FileName != "" && timeConsumingQueriesListView.Tag != null)
            {
                var list = timeConsumingQueriesListView.Tag as List<EFQuery>;
                File.WriteAllLines(saveFileDialog1.FileName, list.Select(q => q.ToString()));
            }
        }

        private void exportSlowestQueriesButton_Click(object sender, EventArgs e)
        {
            var saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "TXT File|*.txt";
            saveFileDialog1.Title = "Save an Text File";
            saveFileDialog1.ShowDialog();

            // If the file name is not an empty string open it for saving.
            if (saveFileDialog1.FileName != "" && slowestQueriesListView.Tag != null)
            {
                var list = slowestQueriesListView.Tag as List<EFQuery>;
                File.WriteAllLines(saveFileDialog1.FileName, list.Select(q => q.ToString()));
            }
        }

        private void exportFrequestQueriesButton_Click(object sender, EventArgs e)
        {
            var saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "TXT File|*.txt";
            saveFileDialog1.Title = "Save an Text File";
            saveFileDialog1.ShowDialog();

            // If the file name is not an empty string open it for saving.
            if (saveFileDialog1.FileName != "" && frequentQueriesListView.Tag != null)
            {
                var list = frequentQueriesListView.Tag as List<EFQuery>;
                File.WriteAllLines(saveFileDialog1.FileName, list.Select(q => q.ToString()));
            }
        }
    }
}