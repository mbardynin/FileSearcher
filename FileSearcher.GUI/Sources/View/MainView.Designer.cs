namespace FileSearcher.GUI.View
{
	partial class MainView
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
			this.components = new System.ComponentModel.Container();
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
			this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
			this.lblWarnings = new System.Windows.Forms.ToolStripStatusLabel();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnSelectPlugin = new System.Windows.Forms.Button();
			this.txtPluginInfo = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.chbIncludeSubDirectories = new System.Windows.Forms.CheckBox();
			this.btnBrowseToDirectory = new System.Windows.Forms.Button();
			this.txtPath = new System.Windows.Forms.TextBox();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnStop = new System.Windows.Forms.Button();
			this.btnSearch = new System.Windows.Forms.Button();
			this.gbxFilters = new System.Windows.Forms.GroupBox();
			this.flpFilters = new System.Windows.Forms.FlowLayoutPanel();
			this.lbxSearchResults = new System.Windows.Forms.ListBox();
			this.iFileInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.statusStrip.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.gbxFilters.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.iFileInfoBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// statusStrip
			// 
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.lblStatus,
            this.lblWarnings});
			this.statusStrip.Location = new System.Drawing.Point(0, 592);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.statusStrip.Size = new System.Drawing.Size(854, 22);
			this.statusStrip.SizingGrip = false;
			this.statusStrip.TabIndex = 0;
			this.statusStrip.Text = "statusStrip1";
			// 
			// toolStripProgressBar1
			// 
			this.toolStripProgressBar1.Enabled = false;
			this.toolStripProgressBar1.Name = "toolStripProgressBar1";
			this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
			this.toolStripProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
			// 
			// lblStatus
			// 
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(39, 17);
			this.lblStatus.Text = "Status";
			this.lblStatus.Visible = false;
			// 
			// lblWarnings
			// 
			this.lblWarnings.ForeColor = System.Drawing.Color.Crimson;
			this.lblWarnings.Name = "lblWarnings";
			this.lblWarnings.Size = new System.Drawing.Size(57, 17);
			this.lblWarnings.Text = "Warnings";
			this.lblWarnings.Visible = false;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.gbxFilters, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.lbxSearchResults, 1, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 107F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(854, 592);
			this.tableLayoutPanel1.TabIndex = 1;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnSelectPlugin);
			this.groupBox1.Controls.Add(this.txtPluginInfo);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.chbIncludeSubDirectories);
			this.groupBox1.Controls.Add(this.btnBrowseToDirectory);
			this.groupBox1.Controls.Add(this.txtPath);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Location = new System.Drawing.Point(3, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(294, 101);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Main search settings";
			// 
			// btnSelectPlugin
			// 
			this.btnSelectPlugin.Location = new System.Drawing.Point(265, 69);
			this.btnSelectPlugin.Name = "btnSelectPlugin";
			this.btnSelectPlugin.Size = new System.Drawing.Size(26, 20);
			this.btnSelectPlugin.TabIndex = 6;
			this.btnSelectPlugin.Text = "...";
			this.btnSelectPlugin.UseVisualStyleBackColor = true;
			// 
			// txtPluginInfo
			// 
			this.txtPluginInfo.Location = new System.Drawing.Point(49, 69);
			this.txtPluginInfo.Name = "txtPluginInfo";
			this.txtPluginInfo.ReadOnly = true;
			this.txtPluginInfo.Size = new System.Drawing.Size(213, 20);
			this.txtPluginInfo.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(10, 70);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(39, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Plugin:";
			// 
			// chbIncludeSubDirectories
			// 
			this.chbIncludeSubDirectories.AutoSize = true;
			this.chbIncludeSubDirectories.Location = new System.Drawing.Point(10, 46);
			this.chbIncludeSubDirectories.Name = "chbIncludeSubDirectories";
			this.chbIncludeSubDirectories.Size = new System.Drawing.Size(139, 17);
			this.chbIncludeSubDirectories.TabIndex = 3;
			this.chbIncludeSubDirectories.Text = "Search in subdirectories";
			this.chbIncludeSubDirectories.UseVisualStyleBackColor = true;
			// 
			// btnBrowseToDirectory
			// 
			this.btnBrowseToDirectory.Location = new System.Drawing.Point(265, 19);
			this.btnBrowseToDirectory.Name = "btnBrowseToDirectory";
			this.btnBrowseToDirectory.Size = new System.Drawing.Size(26, 20);
			this.btnBrowseToDirectory.TabIndex = 2;
			this.btnBrowseToDirectory.Text = "...";
			this.btnBrowseToDirectory.UseVisualStyleBackColor = true;
			// 
			// txtPath
			// 
			this.txtPath.Location = new System.Drawing.Point(6, 19);
			this.txtPath.Name = "txtPath";
			this.txtPath.ReadOnly = true;
			this.txtPath.Size = new System.Drawing.Size(256, 20);
			this.txtPath.TabIndex = 1;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.btnClear);
			this.flowLayoutPanel1.Controls.Add(this.btnStop);
			this.flowLayoutPanel1.Controls.Add(this.btnSearch);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(303, 560);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.flowLayoutPanel1.Size = new System.Drawing.Size(548, 29);
			this.flowLayoutPanel1.TabIndex = 4;
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(470, 3);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(75, 23);
			this.btnClear.TabIndex = 4;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			// 
			// btnStop
			// 
			this.btnStop.Location = new System.Drawing.Point(389, 3);
			this.btnStop.Name = "btnStop";
			this.btnStop.Size = new System.Drawing.Size(75, 23);
			this.btnStop.TabIndex = 5;
			this.btnStop.Text = "Stop";
			this.btnStop.UseVisualStyleBackColor = true;
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(308, 3);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(75, 23);
			this.btnSearch.TabIndex = 3;
			this.btnSearch.Text = "Search";
			this.btnSearch.UseVisualStyleBackColor = true;
			// 
			// gbxFilters
			// 
			this.gbxFilters.AutoSize = true;
			this.gbxFilters.Controls.Add(this.flpFilters);
			this.gbxFilters.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gbxFilters.Location = new System.Drawing.Point(3, 110);
			this.gbxFilters.Name = "gbxFilters";
			this.tableLayoutPanel1.SetRowSpan(this.gbxFilters, 2);
			this.gbxFilters.Size = new System.Drawing.Size(294, 479);
			this.gbxFilters.TabIndex = 5;
			this.gbxFilters.TabStop = false;
			this.gbxFilters.Text = "Filters";
			// 
			// flpFilters
			// 
			this.flpFilters.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flpFilters.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.flpFilters.Location = new System.Drawing.Point(3, 16);
			this.flpFilters.Name = "flpFilters";
			this.flpFilters.Size = new System.Drawing.Size(288, 460);
			this.flpFilters.TabIndex = 0;
			// 
			// lbxSearchResults
			// 
			this.lbxSearchResults.DataSource = this.iFileInfoBindingSource;
			this.lbxSearchResults.DisplayMember = "Name";
			this.lbxSearchResults.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbxSearchResults.FormattingEnabled = true;
			this.lbxSearchResults.Location = new System.Drawing.Point(303, 3);
			this.lbxSearchResults.MultiColumn = true;
			this.lbxSearchResults.Name = "lbxSearchResults";
			this.tableLayoutPanel1.SetRowSpan(this.lbxSearchResults, 2);
			this.lbxSearchResults.Size = new System.Drawing.Size(548, 551);
			this.lbxSearchResults.TabIndex = 6;
			// 
			// iFileInfoBindingSource
			// 
			this.iFileInfoBindingSource.DataSource = typeof(FileSearcher.Common.Model.IFileInfo);
			// 
			// folderBrowserDialog1
			// 
			this.folderBrowserDialog1.Description = "Select the folder in which will search files.";
			this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer;
			this.folderBrowserDialog1.ShowNewFolderButton = false;
			// 
			// MainView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(854, 614);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.statusStrip);
			this.MinimumSize = new System.Drawing.Size(870, 652);
			this.Name = "MainView";
			this.Text = "MainView";
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.gbxFilters.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.iFileInfoBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
		private System.Windows.Forms.ToolStripStatusLabel lblStatus;
		private System.Windows.Forms.ToolStripStatusLabel lblWarnings;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckBox chbIncludeSubDirectories;
		private System.Windows.Forms.Button btnBrowseToDirectory;
		private System.Windows.Forms.TextBox txtPath;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btnStop;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.Button btnSelectPlugin;
		private System.Windows.Forms.TextBox txtPluginInfo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox gbxFilters;
		private System.Windows.Forms.FlowLayoutPanel flpFilters;
		private System.Windows.Forms.ListBox lbxSearchResults;
		private System.Windows.Forms.BindingSource iFileInfoBindingSource;

	}
}