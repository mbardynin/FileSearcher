// Mike Bardynin [mikebardynin@gmail.com]

using System;
using System.ComponentModel;
using System.Windows.Forms;

using FileSearcher.Common.Controller;
using FileSearcher.Common.Model;
using FileSearcher.Common.View;

namespace FileSearcher.GUI.View
{
	public partial class MainView : Form, IMainView
	{
		private Control _pluginControl;
		private int CountFiles
		{ set { lblFilesCount.Text = value.ToString(); }
		}

		public MainView()
		{
			InitializeComponent();
			toolStripProgressBar1.MarqueeAnimationSpeed = 0;
			Warning = "";
			Status = "";
			CountFiles = 0;

			InitHandlers();
		}

		//-------------------------------------------------------------------------------------[]
		public IMainController Controller { get; set; }
		public event EventHandler SelectPlugin = delegate {};
		public event EventHandler StopSearch = delegate {};

		//-------------------------------------------------------------------------------------[]
		public string Warning { get { return lblWarnings.Text; } set { lblWarnings.Text = value; } }
		public string Status { get { return lblStatus.Text; } set { lblStatus.Text = value; } }

		//-------------------------------------------------------------------------------------[]
		public void AddFilters( params Control[] filterControls )
		{
			flpFilters.Controls.AddRange( filterControls );
		}


		#region Routines
		private void InitHandlers()
		{
			btnSearch.Click += ( sender,
				args ) => {
				OnStartSearch();
				searchWorker.RunWorkerAsync( GetMainSettings() );
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

		private void btnBrowseToDirectory_Click(
			object sender,
			EventArgs e )
		{
			var dialogResult = folderBrowserDialog1.ShowDialog();
			if( dialogResult == DialogResult.OK )
				txtPath.Text = folderBrowserDialog1.SelectedPath;
		}
		private void OnSearchWorkerOnDoWork(
			object sender,
			DoWorkEventArgs args )
		{
			var i = 0;
			foreach( var file in Controller.Search( args.Argument as FileSearchSettings ) ) {
				if( searchWorker.CancellationPending ) {
					args.Cancel = true;
					return;
				}
				AddItemToSearchResults( file, i );
				i++;
			}
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
			lvSearchResults.Items.Clear();
		}
		private void UpdatePluginFilter()
		{
			if (_pluginControl != null)
			{
				txtPluginInfo.Clear();
				flpFilters.Controls.Remove(_pluginControl);
			}
			if (Controller.PluginFilter != null &&
				Controller.PluginFilter.UserControl != null)
			{
				_pluginControl = Controller.PluginFilter.UserControl;
				txtPluginInfo.Text = Controller.PluginFilter.ToString();
				AddFilters(_pluginControl);
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
			lvSearchResults.Refresh();
			//dgvSearchResults.Refresh();
			EnableControls(true);
			toolStripProgressBar1.MarqueeAnimationSpeed = 0;
			Status = string.Empty;
			if (args.Cancelled)
				Warning = "Searching was aborted";
			if (args.Error != null)
			{
				Warning = "Exception! " + args.Error.Message;
				MessageBox.Show(args.Error.ToString());
			}
			CountFiles = lvSearchResults.Items.Count;
		}

		private void EnableControls(bool enabled)
		{
			btnStop.Enabled = !enabled;

			btnSearch.Enabled = enabled;
			btnClear.Enabled = enabled;
			gbxFilters.Enabled = enabled;
			gbxMainSearchSettings.Enabled = enabled;
		}

		private void AddItemToSearchResults(
			IFileInfo file,
			int i)
		{
			BeginInvoke(
				new Action(
					() =>
					{
						lvSearchResults.Items.Add(ConvertFileInfoToListViewItem(file));
						if ((i & 1333) == 1333)
							lvSearchResults.Refresh();
					}));
		}

		private static ListViewItem ConvertFileInfoToListViewItem(IFileInfo file)
		{
			return
				new ListViewItem(
					new[] {
						file.Name, ( file.Length/1024 ).ToString(), file.DirectoryName, file.Attributes.ToString(),
						file.CreationTime.ToString(), file.LastAccessTime.ToString(), file.LastWriteTime.ToString()
					});
		}
		#endregion
	}
}