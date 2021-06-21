
namespace Text_Miner
{
    partial class main_search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_search));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmLocation = new System.Windows.Forms.ToolStripMenuItem();
            this.ssBottom = new System.Windows.Forms.StatusStrip();
            this.tssLocation = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssFileCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssFilesChecked = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssComplete = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssLinesRead = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tssPB = new System.Windows.Forms.ProgressBar();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbIncludeLog = new System.Windows.Forms.CheckBox();
            this.cbSearchChild = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTextToFind = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.ssBottom.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmLocation});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(891, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmLocation
            // 
            this.tsmLocation.Image = ((System.Drawing.Image)(resources.GetObject("tsmLocation.Image")));
            this.tsmLocation.Name = "tsmLocation";
            this.tsmLocation.Size = new System.Drawing.Size(28, 20);
            this.tsmLocation.ToolTipText = "Location to search";
            this.tsmLocation.Click += new System.EventHandler(this.tsmLocation_Click);
            // 
            // ssBottom
            // 
            this.ssBottom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssLocation,
            this.tssFileCount,
            this.tssFilesChecked,
            this.tssComplete,
            this.tssLinesRead});
            this.ssBottom.Location = new System.Drawing.Point(0, 366);
            this.ssBottom.Name = "ssBottom";
            this.ssBottom.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            this.ssBottom.Size = new System.Drawing.Size(891, 24);
            this.ssBottom.TabIndex = 1;
            this.ssBottom.Text = "statusStrip1";
            // 
            // tssLocation
            // 
            this.tssLocation.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tssLocation.Name = "tssLocation";
            this.tssLocation.Size = new System.Drawing.Size(98, 19);
            this.tssLocation.Text = "Search Location:";
            this.tssLocation.ToolTipText = "Current search location";
            // 
            // tssFileCount
            // 
            this.tssFileCount.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tssFileCount.Name = "tssFileCount";
            this.tssFileCount.Size = new System.Drawing.Size(74, 19);
            this.tssFileCount.Text = "Total Files: 0";
            // 
            // tssFilesChecked
            // 
            this.tssFilesChecked.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tssFilesChecked.Name = "tssFilesChecked";
            this.tssFilesChecked.Size = new System.Drawing.Size(97, 19);
            this.tssFilesChecked.Text = "Files Searched: 0";
            // 
            // tssComplete
            // 
            this.tssComplete.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tssComplete.Name = "tssComplete";
            this.tssComplete.Size = new System.Drawing.Size(82, 19);
            this.tssComplete.Text = "0% Complete";
            // 
            // tssLinesRead
            // 
            this.tssLinesRead.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tssLinesRead.Name = "tssLinesRead";
            this.tssLinesRead.Size = new System.Drawing.Size(129, 19);
            this.tssLinesRead.Text = "Total Lines Searched: 0";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tssPB);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.cbIncludeLog);
            this.panel1.Controls.Add(this.cbSearchChild);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(733, 24);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(158, 342);
            this.panel1.TabIndex = 2;
            // 
            // tssPB
            // 
            this.tssPB.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tssPB.Location = new System.Drawing.Point(10, 309);
            this.tssPB.Name = "tssPB";
            this.tssPB.Size = new System.Drawing.Size(138, 23);
            this.tssPB.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(14, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(132, 20);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbIncludeLog
            // 
            this.cbIncludeLog.AutoSize = true;
            this.cbIncludeLog.Location = new System.Drawing.Point(16, 59);
            this.cbIncludeLog.Name = "cbIncludeLog";
            this.cbIncludeLog.Size = new System.Drawing.Size(106, 17);
            this.cbIncludeLog.TabIndex = 1;
            this.cbIncludeLog.Text = "Include *.log files";
            this.cbIncludeLog.UseVisualStyleBackColor = true;
            this.cbIncludeLog.CheckedChanged += new System.EventHandler(this.cbIncludeLog_CheckedChanged);
            // 
            // cbSearchChild
            // 
            this.cbSearchChild.AutoSize = true;
            this.cbSearchChild.Location = new System.Drawing.Point(16, 38);
            this.cbSearchChild.Name = "cbSearchChild";
            this.cbSearchChild.Size = new System.Drawing.Size(136, 17);
            this.cbSearchChild.TabIndex = 0;
            this.cbSearchChild.Text = "Search child directories";
            this.cbSearchChild.UseVisualStyleBackColor = true;
            this.cbSearchChild.CheckedChanged += new System.EventHandler(this.cbSearchChild_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtTextToFind);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 24);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.panel2.Size = new System.Drawing.Size(733, 33);
            this.panel2.TabIndex = 3;
            // 
            // txtTextToFind
            // 
            this.txtTextToFind.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTextToFind.Location = new System.Drawing.Point(10, 5);
            this.txtTextToFind.Name = "txtTextToFind";
            this.txtTextToFind.Size = new System.Drawing.Size(713, 20);
            this.txtTextToFind.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.dgvResults);
            this.panel3.Location = new System.Drawing.Point(0, 55);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10);
            this.panel3.Size = new System.Drawing.Size(733, 311);
            this.panel3.TabIndex = 4;
            // 
            // dgvResults
            // 
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column4,
            this.Column2,
            this.Column3,
            this.Column5});
            this.dgvResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResults.Location = new System.Drawing.Point(10, 10);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.RowTemplate.Height = 25;
            this.dgvResults.Size = new System.Drawing.Size(713, 291);
            this.dgvResults.TabIndex = 0;
            this.dgvResults.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResults_CellClick);
            this.dgvResults.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvResults_CellPainting);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.HeaderText = "Line No.";
            this.Column1.Name = "Column1";
            this.Column1.Width = 67;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "View File";
            this.Column4.Name = "Column4";
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column4.Text = "View...";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "Search Results";
            this.Column2.Name = "Column2";
            this.Column2.Width = 96;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.HeaderText = "Last Modified";
            this.Column3.Name = "Column3";
            this.Column3.Width = 87;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "File";
            this.Column5.Name = "Column5";
            this.Column5.Visible = false;
            // 
            // main_search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 390);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ssBottom);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "main_search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text Miner";
            this.Load += new System.EventHandler(this.new_design_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ssBottom.ResumeLayout(false);
            this.ssBottom.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmLocation;
        private System.Windows.Forms.ToolStripStatusLabel tssLocation;
        private System.Windows.Forms.StatusStrip ssBottom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cbSearchChild;
        private System.Windows.Forms.ToolStripStatusLabel tssFileCount;
        private System.Windows.Forms.CheckBox cbIncludeLog;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtTextToFind;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.ToolStripStatusLabel tssFilesChecked;
        private System.Windows.Forms.ToolStripStatusLabel tssComplete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.ToolStripStatusLabel tssLinesRead;
        private System.Windows.Forms.ProgressBar tssPB;
    }
}