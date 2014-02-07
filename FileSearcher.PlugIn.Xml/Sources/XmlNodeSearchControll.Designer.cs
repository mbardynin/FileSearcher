namespace FileSearcher.PlugIn.Xml
{
    partial class XmlNodeSearchControll
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtNodeName = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 5);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Node name:";
			// 
			// txtNodeName
			// 
			this.txtNodeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtNodeName.Location = new System.Drawing.Point(76, 2);
			this.txtNodeName.Name = "txtNodeName";
			this.txtNodeName.Size = new System.Drawing.Size(147, 20);
			this.txtNodeName.TabIndex = 1;
			// 
			// XmlNodeSearchControll
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.txtNodeName);
			this.Controls.Add(this.label1);
			this.MaximumSize = new System.Drawing.Size(800, 25);
			this.MinimumSize = new System.Drawing.Size(223, 25);
			this.Name = "XmlNodeSearchControll";
			this.Size = new System.Drawing.Size(223, 25);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtNodeName;
    }
}
