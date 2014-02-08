// Mike Bardynin [mikebardynin@gmail.com]

using System;
using System.Windows.Forms;

using FileSearcher.Common.View;

namespace FileSearcher.GUI.Controls.Sources
{
	public partial class DateTimeSearchFilterView : UserControl, ISearchFilterView
	{
		public DateTime DateFrom { get { return dtpDateFrom.Value; } }
		public DateTime DateTo
		{
			get
			{
				if (dtpDateTo.Value < DateFrom) {
					dtpDateTo.Value = DateFrom;
				}
				return dtpDateTo.Value;
			}
		}

		bool ISearchFilterView.Enabled { get { return chbEnabled.Checked; } set { chbEnabled.Checked = value; } }

		public new string Text { get { return lblText.Text; } set { lblText.Text = value; } }

		public DateTimeSearchFilterView()
		{
			InitializeComponent();
			bsEnabled.Add( chbEnabled );
		}
	}
}