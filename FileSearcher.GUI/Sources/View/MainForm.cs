// Mike Bardynin [mikebardynin@gmail.com]

using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Windows.Forms;

using FileSearcher.Common;

namespace FileSearcher.GUI.View
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();

			LoadPlugins();

			lbxPlugIns.DisplayMember = "PluginName";
			lbxPlugIns.DataSource = plugInControls;
		}

		private CompositionContainer container;
		private DirectoryCatalog catalog;

		private void LoadPlugins()
		{
			catalog = new DirectoryCatalog( "." );
			container = new CompositionContainer( catalog );
			container.ComposeParts( this );
		}

		[ ImportMany( typeof( SearchControl ), AllowRecomposition = true ) ] private readonly IEnumerable<SearchControl>
			plugInControls = new List<SearchControl>();

		private void btnSetPlugin_Click(
			object sender,
			EventArgs e )
		{
			panelForPlugin.Controls.Clear();
			panelForPlugin.Controls.Add( lbxPlugIns.SelectedItem as SearchControl );
		}

		private void txtGetText1_Click(
			object sender,
			EventArgs e )
		{
			lblResult.Text = ( panelForPlugin.Controls[ 0 ] as SearchControl ).Text1;
		}

		private void btnUpdatePluginsList_Click(
			object sender,
			EventArgs e )
		{
			catalog.Refresh();
			lbxPlugIns.DataSource = plugInControls;
		}
	}
}