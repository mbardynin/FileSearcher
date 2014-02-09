namespace FileSearcher.PlugIn.Txt
{
	partial class TxtSubstringSearchFilterView
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtSubstring = new System.Windows.Forms.TextBox();
			this.bsEnabled = new System.Windows.Forms.BindingSource(this.components);
			this.baseFlowLayoutPanel.SuspendLayout();
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
			this.chbEnabled.Size = new System.Drawing.Size(28, 20);
			this.chbEnabled.TabIndex = 0;
			this.chbEnabled.Text = "|";
			this.chbEnabled.UseVisualStyleBackColor = true;
			// 
			// baseFlowLayoutPanel
			// 
			this.baseFlowLayoutPanel.Controls.Add(this.chbEnabled);
			this.baseFlowLayoutPanel.Controls.Add(this.label1);
			this.baseFlowLayoutPanel.Controls.Add(this.txtSubstring);
			this.baseFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.baseFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.baseFlowLayoutPanel.Name = "baseFlowLayoutPanel";
			this.baseFlowLayoutPanel.Size = new System.Drawing.Size(290, 25);
			this.baseFlowLayoutPanel.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.bsEnabled, "Checked", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.label1.Location = new System.Drawing.Point(37, 4);
			this.label1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(51, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Substring";
			// 
			// txtSubstring
			// 
			this.txtSubstring.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.bsEnabled, "Checked", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.txtSubstring.Location = new System.Drawing.Point(94, 3);
			this.txtSubstring.Name = "txtSubstring";
			this.txtSubstring.Size = new System.Drawing.Size(193, 20);
			this.txtSubstring.TabIndex = 2;
			// 
			// bsEnabled
			// 
			this.bsEnabled.DataSource = typeof(System.Windows.Forms.CheckBox);
			// 
			// TxtSubstringSearchFilterView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.baseFlowLayoutPanel);
			this.Margin = new System.Windows.Forms.Padding(0);
			this.MaximumSize = new System.Drawing.Size(290, 25);
			this.MinimumSize = new System.Drawing.Size(290, 25);
			this.Name = "TxtSubstringSearchFilterView";
			this.Size = new System.Drawing.Size(290, 25);
			this.baseFlowLayoutPanel.ResumeLayout(false);
			this.baseFlowLayoutPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.bsEnabled)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel baseFlowLayoutPanel;
		private System.Windows.Forms.BindingSource bsEnabled;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtSubstring;
		public System.Windows.Forms.CheckBox chbEnabled;
	}
}
