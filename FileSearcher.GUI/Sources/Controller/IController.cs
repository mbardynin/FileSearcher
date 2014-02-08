// Mike Bardynin [mikebardynin@gmail.com]

using System;
using System.IO;
using System.Linq;
using System.Linq.Expressions;

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

		private IFilter BaseFilter { get; set; }
		private IFilter PluginFilter { get; set; }

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

			AddDateTimeFilter(filtersCollection, info => info.CreationTime);
			AddDateTimeFilter(filtersCollection, info => info.LastAccessTime);
			AddDateTimeFilter(filtersCollection, info => info.LastWriteTime);

			AddAttributeFilter(filtersCollection, FileAttributes.ReadOnly);
			AddAttributeFilter(filtersCollection, FileAttributes.Hidden);
			AddAttributeFilter(filtersCollection, FileAttributes.Archive);
			AddAttributeFilter(filtersCollection, FileAttributes.Compressed);
			AddAttributeFilter(filtersCollection, FileAttributes.Encrypted);
			AddAttributeFilter(filtersCollection, FileAttributes.System);
			AddAttributeFilter(filtersCollection, FileAttributes.Temporary);

			BaseFilter = filtersCollection;
		}

		private void AddAttributeFilter(
			FiltersCollection filtersCollection,
			FileAttributes attributes )
		{
			var attributeSearchFilterView = new CheckboxSearchFilterView();
			_view.AddFilters( attributeSearchFilterView );
			filtersCollection.AddHelper( new AttributeFilter( attributeSearchFilterView, attributes ) );
		}

		private void AddDateTimeFilter(
			FiltersCollection filtersCollection,
			Expression<Func<IFileInfo, DateTime>> dateTimeGetter )
		{
			var dateTimeSearchFilterView = new DateTimeSearchFilterView();
			_view.AddFilters( dateTimeSearchFilterView );
			filtersCollection.AddHelper( new DateTimeFilter( dateTimeSearchFilterView, dateTimeGetter ) );
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
	}
}