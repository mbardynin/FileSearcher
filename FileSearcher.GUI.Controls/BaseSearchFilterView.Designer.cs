namespace FileSearcher.Core.Sources.View.Controls
{
	partial class BaseSearchFilterView
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
			this.filteringControlsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.checkBoxBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.baseFlowLayoutPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.checkBoxBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// chbEnabled
			// 
			this.chbEnabled.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.chbEnabled.AutoSize = true;
			this.chbEnabled.Location = new System.Drawing.Point(3, 3);
			this.chbEnabled.Name = "chbEnabled";
			this.chbEnabled.Size = new System.Drawing.Size(65, 17);
			this.chbEnabled.TabIndex = 0;
			this.chbEnabled.Text = "Enabled";
			this.chbEnabled.UseVisualStyleBackColor = true;
			// 
			// baseFlowLayoutPanel
			// 
			this.baseFlowLayoutPanel.Controls.Add(this.chbEnabled);
			this.baseFlowLayoutPanel.Controls.Add(this.filteringControlsFlowLayoutPanel);
			this.baseFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.baseFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.baseFlowLayoutPanel.Name = "baseFlowLayoutPanel";
			this.baseFlowLayoutPanel.Size = new System.Drawing.Size(216, 25);
			this.baseFlowLayoutPanel.TabIndex = 1;
			// 
			// filteringControlsFlowLayoutPanel
			// 
			this.filteringControlsFlowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.filteringControlsFlowLayoutPanel.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.checkBoxBindingSource, "Checked", true));
			this.filteringControlsFlowLayoutPanel.Location = new System.Drawing.Point(74, 3);
			this.filteringControlsFlowLayoutPanel.Name = "filteringControlsFlowLayoutPanel";
			this.filteringControlsFlowLayoutPanel.Size = new System.Drawing.Size(137, 17);
			this.filteringControlsFlowLayoutPanel.TabIndex = 1;
			// 
			// checkBoxBindingSource
			// 
			this.checkBoxBindingSource.DataSource = typeof(System.Windows.Forms.CheckBox);
			// 
			// BaseSearchFilterView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.baseFlowLayoutPanel);
			this.Name = "FileSizeSearchFilterView";
			this.Size = new System.Drawing.Size(216, 25);
			this.baseFlowLayoutPanel.ResumeLayout(false);
			this.baseFlowLayoutPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.checkBoxBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.CheckBox chbEnabled;
		private System.Windows.Forms.FlowLayoutPanel baseFlowLayoutPanel;
		private System.Windows.Forms.BindingSource checkBoxBindingSource;
		protected System.Windows.Forms.FlowLayoutPanel filteringControlsFlowLayoutPanel;
	}
}
