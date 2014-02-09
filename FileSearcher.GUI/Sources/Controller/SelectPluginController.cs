// Mike Bardynin [mikebardynin@gmail.com]

using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Windows.Forms;

using FileSearcher.Common.Controller;
using FileSearcher.GUI.View;

namespace FileSearcher.GUI.Controller
{
	public class SelectPluginController : ISelectPluginController
	{
		private readonly ISelectPluginView _view;
		private DirectoryCatalog _catalog;

		[ ImportMany( typeof( IPluginFilter ), AllowRecomposition = true ) ] private IEnumerable<IPluginFilter> Plugins =
			new List<IPluginFilter>();

		public SelectPluginController()
		{
			_view = new SelectPluginView();
			LoadPlugins();
		}

		public IPluginFilter GetPluginFilter( IPluginFilter oldPluginFilter )
		{
			_catalog.Refresh();
			_view.SetPluginsList( Plugins );
			var result = _view.ShowDialog();
			if( result == DialogResult.OK )
				return _view.SelectedPlugin;
			if (result == DialogResult.Ignore)
				return new NullFilter();
			return oldPluginFilter;
		}

		private void LoadPlugins()
		{
			_catalog = new DirectoryCatalog( "." );
			var container = new CompositionContainer( _catalog );
			container.ComposeParts( this );
		}
	}
}