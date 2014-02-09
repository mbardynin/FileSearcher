// Mike Bardynin [mikebardynin@gmail.com]

using System.Windows.Forms;

using FileSearcher.Common.View;

namespace FileSearcher.PlugIn.Txt
{
	public partial class TxtSubstringSearchFilterView : UserControl, ISearchFilterView
	{
		public string Substring { get { return txtSubstring.Text; } }

		bool ISearchFilterView.Enabled{ get { return chbEnabled.Checked; } set { chbEnabled.Checked = value; } }

		public TxtSubstringSearchFilterView(  )
		{
			InitializeComponent();
			bsEnabled.Add( chbEnabled );
		}
	}
}