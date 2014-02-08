// Mike Bardynin [mikebardynin@gmail.com]

using System;
using System.Linq;

using FileSearcher.Common.Controller;
using FileSearcher.Common.Model;
using FileSearcher.Common.Model.Specifications;
using FileSearcher.Common.View;
using FileSearcher.GUI.Controller.Filters;
using FileSearcher.GUI.Controls.Sources;
using FileSearcher.GUI.Properties;

namespace FileSearcher.GUI.Controller
{
	public interface IController {}

	internal class MainController : IController
	{
		private readonly IFileSearchManager _model;
		private readonly IMainView _view;

		public MainController(
			IFileSearchManager model,
			IMainView view )
		{
			_model = model;
			_view = view;

			_view.StartSearch += StartSearch;
			InitializeBaseFilter();
			PluginFilter = new NullFilter();
		}

		private void InitializeBaseFilter()
		{
			var filtersCollection = new FiltersCollection();

			var fileSizeSearchFilterView = new FileSizeSearchFilterView();
			_view.AddFilters( fileSizeSearchFilterView );
			filtersCollection.AddHelper( new NumbersFilter( fileSizeSearchFilterView ) );

			BaseFilter = filtersCollection;
		}

		private void StartSearch(
			object sender,
			EventArgs e )
		{
			var result = _model.Search(
				_view.GetMainSettings(),
				BaseFilter.GetFilteringSpecification().And( PluginFilter.GetFilteringSpecification() ) ).ToList();
			if( _model.ResultIsLimited )
				_view.Warning = string.Format( "Shown first {0} find files.", Settings.Default.MaxItemsInSearchResults );
			_view.DisplaySearchResult( result );
		}

		public IFilter BaseFilter { get; set; }
		public IFilter PluginFilter { get; set; }
	}

	public interface ISearchFilterController {}
}