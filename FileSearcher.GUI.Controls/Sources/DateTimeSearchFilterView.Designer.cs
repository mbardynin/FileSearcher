namespace FileSearcher.GUI.Controls.Sources
{
	partial class DateTimeSearchFilterView
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.chbEnabled = new System.Windows.Forms.CheckBox();
			this.baseFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.lblText = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.dtpDateFrom = new System.Windows.Forms.DateTimePicker();
			this.bsEnabled = new System.Windows.Forms.BindingSource(this.components);
			this.dtpDateTo = new System.Windows.Forms.DateTimePicker();
			this.baseFlowLayoutPanel.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bsEnabled)).BeginInit();
			this.SuspendLayout();
			// 
			// chbEnabled
			// 
			this.chbEnabled.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.chbEnabled.AutoSize = true;
			this.chbEnabled.Location = new System.Drawing.Point(3, 3);
			this.chbEnabled.Name = "chbEnabled";
			this.chbEnabled.Size = new System.Drawing.Size(28, 54);
			this.chbEnabled.TabIndex = 0;
			this.chbEnabled.Text = "|";
			this.chbEnabled.UseVisualStyleBackColor = true;
			// 
			// baseFlowLayoutPanel
			// 
			this.baseFlowLayoutPanel.Controls.Add(this.chbEnabled);
			this.baseFlowLayoutPanel.Controls.Add(this.lblText);
			this.baseFlowLayoutPanel.Controls.Add(this.label1);
			this.baseFlowLayoutPanel.Controls.Add(this.flowLayoutPanel1);
			this.baseFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.baseFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.baseFlowLayoutPanel.Name = "baseFlowLayoutPanel";
			this.baseFlowLayoutPanel.Size = new System.Drawing.Size(290, 60);
			this.baseFlowLayoutPanel.TabIndex = 1;
			// 
			// lblText
			// 
			this.lblText.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.bsEnabled, "Checked", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.lblText.Location = new System.Drawing.Point(34, 4);
			this.lblText.Margin = new System.Windows.Forms.Padding(0, 4, 3, 0);
			this.lblText.Name = "lblText";
			this.lblText.Size = new System.Drawing.Size(91, 53);
			this.lblText.TabIndex = 1;
			this.lblText.Text = "Date";
			this.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			this.label1.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.bsEnabled, "Checked", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.label1.Location = new System.Drawing.Point(128, 4);
			this.label1.Margin = new System.Windows.Forms.Padding(0, 4, 0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(27, 53);
			this.label1.TabIndex = 1;
			this.label1.Text = "from\r\n\r\nto";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.dtpDateFrom);
			this.flowLayoutPanel1.Controls.Add(this.dtpDateTo);
			this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(158, 3);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(128, 54);
			this.flowLayoutPanel1.TabIndex = 4;
			// 
			// dtpDateFrom
			// 
			this.dtpDateFrom.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.bsEnabled, "Checked", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.dtpDateFrom.Location = new System.Drawing.Point(3, 3);
			this.dtpDateFrom.Name = "dtpDateFrom";
			this.dtpDateFrom.Size = new System.Drawing.Size(119, 20);
			this.dtpDateFrom.TabIndex = 2;
			// 
			// bsEnabled
			// 
			this.bsEnabled.DataSource = typeof(System.Windows.Forms.CheckBox);
			// 
			// dtpDateTo
			// 
			this.dtpDateTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.dtpDateTo.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.bsEnabled, "Checked", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.dtpDateTo.Location = new System.Drawing.Point(3, 29);
			this.dtpDateTo.Name = "dtpDateTo";
			this.dtpDateTo.Size = new System.Drawing.Size(119, 20);
			this.dtpDateTo.TabIndex = 2;
			// 
			// DateTimeSearchFilterView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.baseFlowLayoutPanel);
			this.Margin = new System.Windows.Forms.Padding(0);
			this.MaximumSize = new System.Drawing.Size(290, 60);
			this.MinimumSize = new System.Drawing.Size(290, 60);
			this.Name = "DateTimeSearchFilterView";
			this.Size = new System.Drawing.Size(290, 60);
			this.baseFlowLayoutPanel.ResumeLayout(false);
			this.baseFlowLayoutPanel.PerformLayout();
			this.flowLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.bsEnabled)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel baseFlowLayoutPanel;
		private System.Windows.Forms.BindingSource bsEnabled;
		private System.Windows.Forms.Label lblText;
		private System.Windows.Forms.DateTimePicker dtpDateFrom;
		private System.Windows.Forms.DateTimePicker dtpDateTo;
		public System.Windows.Forms.CheckBox chbEnabled;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
	}
}
