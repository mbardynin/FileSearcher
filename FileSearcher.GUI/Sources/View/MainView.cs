// Mike Bardynin [mikebardynin@gmail.com]

using System;
using System.Collections.Generic;
using System.Windows.Forms;

using FileSearcher.Common;

namespace FileSearcher.GUI.View
{
	public partial class MainView : Form, IMainView
	{
		public MainView()
		{
			InitializeComponent();
			btnSearch.Click += ( sender,
				args ) => StartSearch(sender, args);
		}

		public event EventHandler StartSearch = delegate {};

		public void AddFilters( params Control[] filterControls )
		{
			flpFilters.Controls.AddRange(filterControls);
		}

		public void DisplaySearchResult( IEnumerable<IFileInfo> fileInfoList )
		{
			throw new NotImplementedException();
		}

	}
}