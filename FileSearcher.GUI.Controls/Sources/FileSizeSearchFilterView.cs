// Mike Bardynin [mikebardynin@gmail.com]

using System;
using System.Windows.Forms;

using FileSearcher.Common;
using FileSearcher.Common.View;

namespace FileSearcher.GUI.Controls.Sources
{
	public partial class FileSizeSearchFilterView : UserControl, ISearchFilterView
	{
		public long MinSize { get { return Convert.ToInt64(nudMinSize.Value); } }
		public long MaxSize
		{
			get
			{
				long maxSize = Convert.ToInt64( nudMaxSize.Value );
				var maxValue = Math.Max( maxSize, MinSize );
				nudMaxSize.Value = maxValue;
				return maxValue;
			}
		}

		bool ISearchFilterView.Enabled{ get { return chbEnabled.Checked; } set { chbEnabled.Checked = value; } }

		public FileSizeSearchFilterView(  )
		{
			InitializeComponent();
			bsEnabled.Add( chbEnabled );
		}
	}
}