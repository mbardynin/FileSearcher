// Mike Bardynin [mikebardynin@gmail.com]

using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Windows.Forms;

using FileSearcher.Common;
using FileSearcher.Common.View;

namespace FileSearcher.GUI.View
{
	public partial class SelectPluginView : Form
	{
		public SelectPluginView()
		{
			InitializeComponent();

			LoadPlugins();
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


		private void btnUpdatePluginsList_Click(
			object sender,
			EventArgs e )
		{
			catalog.Refresh();
		}
	}
}