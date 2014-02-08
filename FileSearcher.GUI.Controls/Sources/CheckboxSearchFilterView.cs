// Mike Bardynin [mikebardynin@gmail.com]

using System.Windows.Forms;

using FileSearcher.Common.View;

namespace FileSearcher.GUI.Controls.Sources
{
	public partial class CheckboxSearchFilterView : UserControl, ISearchFilterView
	{
		public bool Checked { get { return chbChosen.Checked; } }

		public new string Text { get { return chbChosen.Text; } set { chbChosen.Text = value; } }

		bool ISearchFilterView.Enabled { get { return chbEnabled.Checked; } set { chbEnabled.Checked = value; } }

		public CheckboxSearchFilterView()
		{
			InitializeComponent();
			bsEnabled.Add( chbEnabled );
		}
	}
}