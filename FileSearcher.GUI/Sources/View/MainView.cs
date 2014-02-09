// Mike Bardynin [mikebardynin@gmail.com]

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Remoting.Services;
using System.Threading;
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
			Warning = "";
			Status = "";

			btnSearch.Click += ( sender,
				args ) => { 
				OnStartSearch();
				searchWorker.RunWorkerAsync(GetMainSettings());
			};

			btnClear.Click += ( sender,
				args ) => ClearSearchResults();

			btnSelectPlugin.Click += ( sender,
				args ) => {
				SelectPlugin( sender, args );
				UpdatePluginFilter();
			};

			btnStop.Click += ( sender,
				args ) => searchWorker.CancelAsync();

			searchWorker.RunWorkerCompleted += ( sender,
				args ) => {
				OnStopSearch( args );
				StopSearch( sender, args );
			};

			searchWorker.DoWork += OnSearchWorkerOnDoWork;
		}

		private void OnSearchWorkerOnDoWork( object sender,
			DoWorkEventArgs args )
		{
			int i = 0; 
			foreach( var file in Controller.Search( args.Argument as FileSearchSettings ) ) {
				if( searchWorker.CancellationPending ) {
					args.Cancel = true;
					return;
				}
				this.BeginInvoke(new Action(() =>
				{
					iFileInfoBindingSource.Add(file);
					if((i&133) == 133)
						dgvSearchResults.Refresh();
				}));
				i++;
			}
		}

		//-------------------------------------------------------------------------------------[]
		public IMainController Controller { get; set; }
		public event EventHandler SelectPlugin = delegate {};
		public event EventHandler StopSearch = delegate {};

		//-------------------------------------------------------------------------------------[]
		public string Warning { get { return lblWarnings.Text; } set { lblWarnings.Text = value; } }
		public string Status { get { return lblStatus.Text; } set { lblStatus.Text = value; } }
		public int CountFiles { get { return int.Parse( lblFilesCount.Text ); } set { lblFilesCount.Text = value.ToString(); } }

		//-------------------------------------------------------------------------------------[]
		public void AddFilters( params Control[] filterControls )
		{
			flpFilters.Controls.AddRange( filterControls );
		}

		public void DisplaySearchResult( IEnumerable<IFileInfo> fileInfoList )
		{
			searchWorker.RunWorkerAsync(fileInfoList);
			iFileInfoBindingSource.DataSource = fileInfoList;
		}

		private FileSearchSettings GetMainSettings()
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
			if( pluginControl != null ) {
				txtPluginInfo.Clear();
				flpFilters.Controls.Remove( pluginControl );
			}
			if( Controller.PluginFilter != null &&
			    Controller.PluginFilter.UserControl != null ) {
				pluginControl = Controller.PluginFilter.UserControl;
				txtPluginInfo.Text = Controller.PluginFilter.ToString();
				AddFilters( pluginControl );
			}
		}

		private void OnStartSearch()
		{
			ClearSearchResults();
			EnableControls(false);
			toolStripProgressBar1.MarqueeAnimationSpeed = 100;
			Status = "Searching files in directory " + txtPath.Text;
			Warning = "";

		}

		private void OnStopSearch(RunWorkerCompletedEventArgs args)
		{
			dgvSearchResults.Refresh();
			EnableControls(true);
			toolStripProgressBar1.MarqueeAnimationSpeed = 0;
			Status = string.Empty;
			if (args.Cancelled)
				Warning = "Searching was aborted";
			if( args.Error != null ) {
				Warning = "Exception! " + args.Error.Message;
				MessageBox.Show(args.Error.ToString());
			}
			CountFiles = iFileInfoBindingSource.Count;

		}

		private void EnableControls( bool enabled )
		{
			btnStop.Enabled = !enabled;

			btnSearch.Enabled = enabled;
			btnClear.Enabled = enabled;
			gbxFilters.Enabled = enabled;
			gbxMainSearchSettings.Enabled = enabled;
		}
	}
}