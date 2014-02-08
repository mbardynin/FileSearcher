namespace FileSearcher.GUI.Controls.Sources
{
	partial class CheckboxSearchFilterView
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
			this.bsEnabled = new System.Windows.Forms.BindingSource(this.components);
			this.chbChosen = new System.Windows.Forms.CheckBox();
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
			this.chbEnabled.Size = new System.Drawing.Size(28, 17);
			this.chbEnabled.TabIndex = 0;
			this.chbEnabled.Text = "|";
			this.chbEnabled.UseVisualStyleBackColor = true;
			// 
			// baseFlowLayoutPanel
			// 
			this.baseFlowLayoutPanel.Controls.Add(this.chbEnabled);
			this.baseFlowLayoutPanel.Controls.Add(this.chbChosen);
			this.baseFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.baseFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.baseFlowLayoutPanel.Name = "baseFlowLayoutPanel";
			this.baseFlowLayoutPanel.Size = new System.Drawing.Size(290, 25);
			this.baseFlowLayoutPanel.TabIndex = 1;
			// 
			// bsEnabled
			// 
			this.bsEnabled.DataSource = typeof(System.Windows.Forms.CheckBox);
			// 
			// chbChosen
			// 
			this.chbChosen.AutoSize = true;
			this.chbChosen.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.bsEnabled, "Checked", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.chbChosen.Location = new System.Drawing.Point(37, 3);
			this.chbChosen.Name = "chbChosen";
			this.chbChosen.Size = new System.Drawing.Size(80, 17);
			this.chbChosen.TabIndex = 1;
			this.chbChosen.Text = "checkBox1";
			this.chbChosen.UseVisualStyleBackColor = true;
			// 
			// CheckboxSearchFilterView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.baseFlowLayoutPanel);
			this.MaximumSize = new System.Drawing.Size(290, 25);
			this.MinimumSize = new System.Drawing.Size(290, 25);
			this.Name = "CheckboxSearchFilterView";
			this.Size = new System.Drawing.Size(290, 25);
			this.baseFlowLayoutPanel.ResumeLayout(false);
			this.baseFlowLayoutPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.bsEnabled)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel baseFlowLayoutPanel;
		private System.Windows.Forms.BindingSource bsEnabled;
		public System.Windows.Forms.CheckBox chbEnabled;
		private System.Windows.Forms.CheckBox chbChosen;
	}
}
