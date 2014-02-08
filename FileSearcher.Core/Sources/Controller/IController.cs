// Mike Bardynin [mikebardynin@gmail.com]

using FileSearcher.Core.Filters;
using FileSearcher.Core.Model;
using FileSearcher.GUI;

namespace FileSearcher.Core.Controller
{
	public interface IController
	{
		 
	}

	class MainController : IController
	{
		private FileSearchManager _model;
		private MainForm _view;

		public MainController( FileSearchManager model,
			MainForm view )
		{
			_model = model;
			_view = view;

			//_view
		}

		public IFilter BaseFilter { get; set; }
		public IFilter PluginFilter { get; set; }
	}

	public interface ISearchFilterController
	{
		 
	}
}