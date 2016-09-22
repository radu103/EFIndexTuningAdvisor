namespace EFIndexTuningAdvisorTestApp
{
    partial class TestForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.exportSQLForIndexCreationButton = new System.Windows.Forms.Button();
            this.testAdventureWorks = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.missingIndexesTreeView = new System.Windows.Forms.TreeView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.frequentQueriesListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.timeConsumingQueriesListView = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.slowestQueriesListView = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.exportTimeConsumingQueries = new System.Windows.Forms.Button();
            this.exportSlowestQueriesButton = new System.Windows.Forms.Button();
            this.seeCapturedQueriesbutton = new System.Windows.Forms.Button();
            this.exportFrequestQueriesButton = new System.Windows.Forms.Button();
            this.RunTestQuesriesBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.exportSQLForIndexCreationButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.testAdventureWorks, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox4, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.exportTimeConsumingQueries, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.exportSlowestQueriesButton, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.seeCapturedQueriesbutton, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.exportFrequestQueriesButton, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1366, 671);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // exportSQLForIndexCreationButton
            // 
            this.exportSQLForIndexCreationButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exportSQLForIndexCreationButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.exportSQLForIndexCreationButton.Location = new System.Drawing.Point(52, 638);
            this.exportSQLForIndexCreationButton.Name = "exportSQLForIndexCreationButton";
            this.exportSQLForIndexCreationButton.Size = new System.Drawing.Size(236, 28);
            this.exportSQLForIndexCreationButton.TabIndex = 7;
            this.exportSQLForIndexCreationButton.Text = "Export SQL for Index creation";
            this.exportSQLForIndexCreationButton.UseVisualStyleBackColor = true;
            this.exportSQLForIndexCreationButton.Click += new System.EventHandler(this.exportSQLForIndexCreationButton_Click);
            // 
            // testAdventureWorks
            // 
            this.testAdventureWorks.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.testAdventureWorks.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.testAdventureWorks.Location = new System.Drawing.Point(29, 6);
            this.testAdventureWorks.Name = "testAdventureWorks";
            this.testAdventureWorks.Size = new System.Drawing.Size(282, 28);
            this.testAdventureWorks.TabIndex = 0;
            this.testAdventureWorks.Text = "Test Wide World Importers EF Context";
            this.testAdventureWorks.UseVisualStyleBackColor = true;
            this.testAdventureWorks.Click += new System.EventHandler(this.testAdventureWorks_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.missingIndexesTreeView);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 587);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DB Indexes Missing ";
            // 
            // missingIndexesTreeView
            // 
            this.missingIndexesTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.missingIndexesTreeView.Location = new System.Drawing.Point(3, 18);
            this.missingIndexesTreeView.Name = "missingIndexesTreeView";
            this.missingIndexesTreeView.ShowNodeToolTips = true;
            this.missingIndexesTreeView.Size = new System.Drawing.Size(329, 566);
            this.missingIndexesTreeView.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.frequentQueriesListView);
            this.groupBox2.Location = new System.Drawing.Point(344, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(335, 587);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Frequent Queries";
            // 
            // frequentQueriesListView
            // 
            this.frequentQueriesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.frequentQueriesListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frequentQueriesListView.Location = new System.Drawing.Point(3, 18);
            this.frequentQueriesListView.Name = "frequentQueriesListView";
            this.frequentQueriesListView.ShowItemToolTips = true;
            this.frequentQueriesListView.Size = new System.Drawing.Size(329, 566);
            this.frequentQueriesListView.TabIndex = 0;
            this.frequentQueriesListView.UseCompatibleStateImageBehavior = false;
            this.frequentQueriesListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Query";
            this.columnHeader1.Width = 180;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Count";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.timeConsumingQueriesListView);
            this.groupBox3.Location = new System.Drawing.Point(685, 43);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(335, 587);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Time Consuming Queries";
            // 
            // timeConsumingQueriesListView
            // 
            this.timeConsumingQueriesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.timeConsumingQueriesListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeConsumingQueriesListView.Location = new System.Drawing.Point(3, 18);
            this.timeConsumingQueriesListView.Name = "timeConsumingQueriesListView";
            this.timeConsumingQueriesListView.ShowItemToolTips = true;
            this.timeConsumingQueriesListView.Size = new System.Drawing.Size(329, 566);
            this.timeConsumingQueriesListView.TabIndex = 1;
            this.timeConsumingQueriesListView.UseCompatibleStateImageBehavior = false;
            this.timeConsumingQueriesListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Query";
            this.columnHeader3.Width = 174;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Time (ms)";
            this.columnHeader4.Width = 80;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.slowestQueriesListView);
            this.groupBox4.Location = new System.Drawing.Point(1026, 43);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(335, 587);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Slowest Queries";
            // 
            // slowestQueriesListView
            // 
            this.slowestQueriesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6});
            this.slowestQueriesListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slowestQueriesListView.Location = new System.Drawing.Point(3, 18);
            this.slowestQueriesListView.Name = "slowestQueriesListView";
            this.slowestQueriesListView.ShowItemToolTips = true;
            this.slowestQueriesListView.Size = new System.Drawing.Size(329, 566);
            this.slowestQueriesListView.TabIndex = 2;
            this.slowestQueriesListView.UseCompatibleStateImageBehavior = false;
            this.slowestQueriesListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Query";
            this.columnHeader5.Width = 170;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Time (ms)";
            this.columnHeader6.Width = 80;
            // 
            // exportTimeConsumingQueries
            // 
            this.exportTimeConsumingQueries.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exportTimeConsumingQueries.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.exportTimeConsumingQueries.Location = new System.Drawing.Point(734, 638);
            this.exportTimeConsumingQueries.Name = "exportTimeConsumingQueries";
            this.exportTimeConsumingQueries.Size = new System.Drawing.Size(236, 28);
            this.exportTimeConsumingQueries.TabIndex = 6;
            this.exportTimeConsumingQueries.Text = "Export Time Consuming Queries";
            this.exportTimeConsumingQueries.UseVisualStyleBackColor = true;
            this.exportTimeConsumingQueries.Click += new System.EventHandler(this.exportTimeConsumingQueries_Click);
            // 
            // exportSlowestQueriesButton
            // 
            this.exportSlowestQueriesButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exportSlowestQueriesButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.exportSlowestQueriesButton.Location = new System.Drawing.Point(1076, 638);
            this.exportSlowestQueriesButton.Name = "exportSlowestQueriesButton";
            this.exportSlowestQueriesButton.Size = new System.Drawing.Size(236, 28);
            this.exportSlowestQueriesButton.TabIndex = 9;
            this.exportSlowestQueriesButton.Text = "Export Slowest Queries";
            this.exportSlowestQueriesButton.UseVisualStyleBackColor = true;
            this.exportSlowestQueriesButton.Click += new System.EventHandler(this.exportSlowestQueriesButton_Click);
            // 
            // seeCapturedQueriesbutton
            // 
            this.seeCapturedQueriesbutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.seeCapturedQueriesbutton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.seeCapturedQueriesbutton.Location = new System.Drawing.Point(1099, 6);
            this.seeCapturedQueriesbutton.Name = "seeCapturedQueriesbutton";
            this.seeCapturedQueriesbutton.Size = new System.Drawing.Size(191, 28);
            this.seeCapturedQueriesbutton.TabIndex = 5;
            this.seeCapturedQueriesbutton.Text = "See captured Queries";
            this.seeCapturedQueriesbutton.UseVisualStyleBackColor = true;
            this.seeCapturedQueriesbutton.Click += new System.EventHandler(this.seeCapturedQueriesbutton_Click);
            // 
            // exportFrequestQueriesButton
            // 
            this.exportFrequestQueriesButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exportFrequestQueriesButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.exportFrequestQueriesButton.Location = new System.Drawing.Point(393, 638);
            this.exportFrequestQueriesButton.Name = "exportFrequestQueriesButton";
            this.exportFrequestQueriesButton.Size = new System.Drawing.Size(236, 28);
            this.exportFrequestQueriesButton.TabIndex = 8;
            this.exportFrequestQueriesButton.Text = "Export Frequent Queries";
            this.exportFrequestQueriesButton.UseVisualStyleBackColor = true;
            this.exportFrequestQueriesButton.Click += new System.EventHandler(this.exportFrequestQueriesButton_Click);
            // 
            // RunTestQuesriesBackgroundWorker
            // 
            this.RunTestQuesriesBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.RunTestQuesriesBackgroundWorker_DoWork);
            this.RunTestQuesriesBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.RunTestQuesriesBackgroundWorker_RunWorkerCompleted);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 671);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "TestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EFTuningAdvisor Test App";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button testAdventureWorks;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button seeCapturedQueriesbutton;
        private System.ComponentModel.BackgroundWorker RunTestQuesriesBackgroundWorker;
        private System.Windows.Forms.TreeView missingIndexesTreeView;
        private System.Windows.Forms.ListView frequentQueriesListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView timeConsumingQueriesListView;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView slowestQueriesListView;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button exportSQLForIndexCreationButton;
        private System.Windows.Forms.Button exportTimeConsumingQueries;
        private System.Windows.Forms.Button exportFrequestQueriesButton;
        private System.Windows.Forms.Button exportSlowestQueriesButton;
    }
}

