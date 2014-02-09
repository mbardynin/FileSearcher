namespace FileSearcher.PlugIn.Xml
{
	partial class XmlNodeValueSearchFilterView
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
			this.txtNodeName = new System.Windows.Forms.TextBox();
			this.bsEnabled = new System.Windows.Forms.BindingSource(this.components);
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.label2 = new System.Windows.Forms.Label();
			this.txtValue = new System.Windows.Forms.TextBox();
			this.baseFlowLayoutPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bsEnabled)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// chbEnabled
			// 
			this.chbEnabled.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.chbEnabled.AutoSize = true;
			this.chbEnabled.Location = new System.Drawing.Point(3, 3);
			this.chbEnabled.Name = "chbEnabled";
			this.chbEnabled.Size = new System.Drawing.Size(28, 44);
			this.chbEnabled.TabIndex = 0;
			this.chbEnabled.Text = "|";
			this.chbEnabled.UseVisualStyleBackColor = true;
			// 
			// baseFlowLayoutPanel
			// 
			this.baseFlowLayoutPanel.Controls.Add(this.chbEnabled);
			this.baseFlowLayoutPanel.Controls.Add(this.tableLayoutPanel1);
			this.baseFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.baseFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.baseFlowLayoutPanel.Name = "baseFlowLayoutPanel";
			this.baseFlowLayoutPanel.Size = new System.Drawing.Size(290, 50);
			this.baseFlowLayoutPanel.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 4);
			this.label1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Node name:";
			// 
			// txtNodeName
			// 
			this.txtNodeName.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.bsEnabled, "Checked", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.txtNodeName.Location = new System.Drawing.Point(72, 1);
			this.txtNodeName.Margin = new System.Windows.Forms.Padding(1);
			this.txtNodeName.Name = "txtNodeName";
			this.txtNodeName.Size = new System.Drawing.Size(177, 20);
			this.txtNodeName.TabIndex = 2;
			// 
			// bsEnabled
			// 
			this.bsEnabled.DataSource = typeof(System.Windows.Forms.CheckBox);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.txtNodeName, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.txtValue, 1, 1);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(37, 3);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(250, 44);
			this.tableLayoutPanel1.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 26);
			this.label2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(37, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Value:";
			// 
			// txtValue
			// 
			this.txtValue.Location = new System.Drawing.Point(72, 23);
			this.txtValue.Margin = new System.Windows.Forms.Padding(1);
			this.txtValue.Name = "txtValue";
			this.txtValue.Size = new System.Drawing.Size(177, 20);
			this.txtValue.TabIndex = 2;
			// 
			// XmlNodeValueSearchFilterView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.baseFlowLayoutPanel);
			this.Margin = new System.Windows.Forms.Padding(0);
			this.MaximumSize = new System.Drawing.Size(290, 50);
			this.MinimumSize = new System.Drawing.Size(290, 50);
			this.Name = "XmlNodeValueSearchFilterView";
			this.Size = new System.Drawing.Size(290, 50);
			this.baseFlowLayoutPanel.ResumeLayout(false);
			this.baseFlowLayoutPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.bsEnabled)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel baseFlowLayoutPanel;
		private System.Windows.Forms.BindingSource bsEnabled;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtNodeName;
		public System.Windows.Forms.CheckBox chbEnabled;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtValue;
	}
}
