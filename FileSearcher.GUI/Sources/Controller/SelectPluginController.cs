// Mike Bardynin [mikebardynin@gmail.com]

using FileSearcher.Common.Controller;

namespace FileSearcher.GUI.Controller
{
	public class SelectPluginController
	{
		private ISelectPluginView _view;



		public IPluginFilter PluginFilter { get; private set; }


	}

	internal interface ISelectPluginView {}
}