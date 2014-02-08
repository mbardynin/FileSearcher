// Mike Bardynin [mikebardynin@gmail.com]

using System;
using System.Collections.Generic;
using System.Windows.Forms;

using FileSearcher.Common;

namespace FileSearcher.GUI.Sources
{
	public partial class MainView : Form, IMainView
	{
		public MainView()
		{
			InitializeComponent();
		}

		public void AddFilters( params Control[] filterControls )
		{
			throw new NotImplementedException();
		}

		public event Action StartSearch;

		public void DisplaySearchResult( IEnumerable<IFileInfo> fileInfoList )
		{
			throw new NotImplementedException();
		}

		private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
		{
			}
	}
}