// Mike Bardynin [mikebardynin@gmail.com]

using System;
using System.Collections.Generic;
using System.Windows.Forms;

using FileSearcher.Common.Model;
using FileSearcher.Common.View;

namespace FileSearcher.GUI.View
{
	public partial class MainView : Form, IMainView
	{
		public MainView()
		{
			InitializeComponent();
			btnSearch.Click += ( sender,
				args ) => StartSearch( sender, args );
		}

		//-------------------------------------------------------------------------------------[]
		public event EventHandler StartSearch = delegate {};

		//-------------------------------------------------------------------------------------[]
		public string Warning { get { return lblWarnings.Text; } set { lblWarnings.Text = value; } }
		public string Status { get { return lblStatus.Text; } set { lblStatus.Text = value; } }

		//-------------------------------------------------------------------------------------[]
		public void AddFilters( params Control[] filterControls )
		{
			flpFilters.Controls.AddRange( filterControls );
		}

		public void DisplaySearchResult( IEnumerable<IFileInfo> fileInfoList )
		{
			iFileInfoBindingSource.DataSource = fileInfoList;
		}


		public FileSearchSettings GetMainSettings()
		{
			return new FileSearchSettings() {
				Path = txtPath.Text,
				IncludeSubDirectories = chbIncludeSubDirectories.Checked,
				FileExtension = "*"
			};
		}

		private void ClearSearchResults()
		{
			lbxSearchResults.Items.Clear();
		}
	}
}