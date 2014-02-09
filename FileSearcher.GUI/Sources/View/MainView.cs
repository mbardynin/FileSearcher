// Mike Bardynin [mikebardynin@gmail.com]

using System;
using System.Collections.Generic;
using System.Windows.Forms;

using FileSearcher.Common.Controller;
using FileSearcher.Common.Model;
using FileSearcher.Common.View;

namespace FileSearcher.GUI.View
{
	public partial class MainView : Form, IMainView
	{
		private Control pluginControl;

		public MainView()
		{
			InitializeComponent();
			toolStripProgressBar1.MarqueeAnimationSpeed = 0;

			btnSearch.Click += ( sender,
				args ) => {
				Warning = "";
				StartSearch( sender, args );
			};

			btnClear.Click += ( sender,
				args ) => ClearSearchResults();

			btnSelectPlugin.Click += ( sender,
				args) => {
				SelectPlugin( sender, args );
				UpdatePluginFilter();
			};

			btnStop.Click += (sender,
				args) => StopSearch(sender, args);
		}

		//-------------------------------------------------------------------------------------[]
		public IMainController Controller { get; set; }
		public event EventHandler StartSearch = delegate { };
		public event EventHandler SelectPlugin = delegate { };
		public event EventHandler StopSearch = delegate { };

		//-------------------------------------------------------------------------------------[]
		public string Warning
		{
			get { return lblWarnings.Text; }
			set
			{
				lblWarnings.Text = value;
			}
		}
		public string Status
		{
			get { return lblStatus.Text; }
			set
			{
				lblStatus.Text = value;
			}
		}

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

		//-------------------------------------------------------------------------------------[]
		private void ClearSearchResults()
		{
			iFileInfoBindingSource.Clear();
		}

		private void btnBrowseToDirectory_Click(
			object sender,
			EventArgs e )
		{
			var dialogResult = folderBrowserDialog1.ShowDialog();
			if( dialogResult == DialogResult.OK )
				txtPath.Text = folderBrowserDialog1.SelectedPath;
		}

		private void UpdatePluginFilter()
		{
			if( Controller.PluginFilter!= null && Controller.PluginFilter.UserControl != null ) {
				if( pluginControl != null )
					flpFilters.Controls.Remove( pluginControl );
				pluginControl = Controller.PluginFilter.UserControl;
				txtPluginInfo.Text = Controller.PluginFilter.ToString();
				AddFilters( pluginControl );
			}
		}
	}
}