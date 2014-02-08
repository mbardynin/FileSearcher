// Mike Bardynin [mikebardynin@gmail.com]

using FileSearcher.Common;
using FileSearcher.Core.Model;
using FileSearcher.GUI.Filters;
using FileSearcher.GUI.View;

namespace FileSearcher.GUI.Controller
{
	public interface IController
	{
		 
	}

	class MainController : IController
	{
		private IFileSearchManager _model;
		private IMainView _view;

		public MainController(IFileSearchManager model,
			IMainView view )
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