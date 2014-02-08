// Mike Bardynin [mikebardynin@gmail.com]

using System;
using System.Windows.Forms;

using FileSearcher.Common;

namespace FileSearcher.GUI.Controls.Sources
{
	public partial class FileSizeSearchFilterView : UserControl, ISearchFilterView
	{
		public long MinSize { get { return Convert.ToInt64(nudMinSize.Value); } }
		public long MaxSize { get { return Convert.ToInt64(nudMaxSize.Value); } }

		bool ISearchFilterView.Enabled{ get { return chbEnabled.Checked; } set { chbEnabled.Checked = value; } }

		public FileSizeSearchFilterView(  )
		{
			InitializeComponent();
			bsEnabled.Add( chbEnabled );
		}
	}
}