namespace FileSearcher.GUI
{
	partial class Form1
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
			this.lbxPlugIns = new System.Windows.Forms.ListBox();
			this.btnSetPlugin = new System.Windows.Forms.Button();
			this.txtGetText1 = new System.Windows.Forms.Button();
			this.lblResult = new System.Windows.Forms.Label();
			this.panelForPlugin = new System.Windows.Forms.FlowLayoutPanel();
			this.btnUpdatePluginsList = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lbxPlugIns
			// 
			this.lbxPlugIns.FormattingEnabled = true;
			this.lbxPlugIns.Location = new System.Drawing.Point(12, 5);
			this.lbxPlugIns.Name = "lbxPlugIns";
			this.lbxPlugIns.Size = new System.Drawing.Size(117, 316);
			this.lbxPlugIns.TabIndex = 0;
			// 
			// btnSetPlugin
			// 
			this.btnSetPlugin.Location = new System.Drawing.Point(12, 327);
			this.btnSetPlugin.Name = "btnSetPlugin";
			this.btnSetPlugin.Size = new System.Drawing.Size(65, 23);
			this.btnSetPlugin.TabIndex = 1;
			this.btnSetPlugin.Text = "SetPlugin";
			this.btnSetPlugin.UseVisualStyleBackColor = true;
			this.btnSetPlugin.Click += new System.EventHandler(this.btnSetPlugin_Click);
			// 
			// txtGetText1
			// 
			this.txtGetText1.Location = new System.Drawing.Point(532, 327);
			this.txtGetText1.Name = "txtGetText1";
			this.txtGetText1.Size = new System.Drawing.Size(75, 23);
			this.txtGetText1.TabIndex = 3;
			this.txtGetText1.Text = "GetText";
			this.txtGetText1.UseVisualStyleBackColor = true;
			this.txtGetText1.Click += new System.EventHandler(this.txtGetText1_Click);
			// 
			// lblResult
			// 
			this.lblResult.AutoSize = true;
			this.lblResult.Location = new System.Drawing.Point(387, 328);
			this.lblResult.Name = "lblResult";
			this.lblResult.Size = new System.Drawing.Size(35, 13);
			this.lblResult.TabIndex = 4;
			this.lblResult.Text = "label1";
			// 
			// panelForPlugin
			// 
			this.panelForPlugin.Location = new System.Drawing.Point(373, 12);
			this.panelForPlugin.Name = "panelForPlugin";
			this.panelForPlugin.Size = new System.Drawing.Size(234, 54);
			this.panelForPlugin.TabIndex = 5;
			// 
			// btnUpdatePluginsList
			// 
			this.btnUpdatePluginsList.Location = new System.Drawing.Point(12, 356);
			this.btnUpdatePluginsList.Name = "btnUpdatePluginsList";
			this.btnUpdatePluginsList.Size = new System.Drawing.Size(65, 23);
			this.btnUpdatePluginsList.TabIndex = 1;
			this.btnUpdatePluginsList.Text = "UpdateList";
			this.btnUpdatePluginsList.UseVisualStyleBackColor = true;
			this.btnUpdatePluginsList.Click += new System.EventHandler(this.btnUpdatePluginsList_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(619, 398);
			this.Controls.Add(this.panelForPlugin);
			this.Controls.Add(this.lblResult);
			this.Controls.Add(this.txtGetText1);
			this.Controls.Add(this.btnUpdatePluginsList);
			this.Controls.Add(this.btnSetPlugin);
			this.Controls.Add(this.lbxPlugIns);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox lbxPlugIns;
		private System.Windows.Forms.Button btnSetPlugin;
		private System.Windows.Forms.Button txtGetText1;
		private System.Windows.Forms.Label lblResult;
		private System.Windows.Forms.FlowLayoutPanel panelForPlugin;
		private System.Windows.Forms.Button btnUpdatePluginsList;

	}
}

