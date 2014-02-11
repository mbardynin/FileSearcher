﻿// Mike Bardynin [mikebardynin@gmail.com]

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;

using FileSearcher.Common;
using FileSearcher.Common.Controller;
using FileSearcher.Common.Controller.Filters;
using FileSearcher.Common.Model;
using FileSearcher.Common.Model.Specifications;
using FileSearcher.Common.View;
using FileSearcher.GUI.Controller.Filters;
using FileSearcher.GUI.Controls.Sources;
using FileSearcher.GUI.Model;
using FileSearcher.GUI.Properties;
using FileSearcher.GUI.View;

namespace FileSearcher.GUI.Controller
{
	internal class MainController : IMainController
	{
		private readonly IFileSearchManager _model;
		private readonly IMainView _view;
		private readonly ISelectPluginController _selectPluginController;

		private IFilter BaseFilter { get; set; }
		public IPluginFilter PluginFilter { get; set; }
		public IEnumerable<IFileInfo> Search( FileSearchSettings fileSearchSettings )
		{
			if (PluginFilter != null && PluginFilter.FileExtension.IsNotEmpty())
				fileSearchSettings.FileExtension = PluginFilter.FileExtension;

			return _model.Search(
				fileSearchSettings,
				BaseFilter.GetSpecification().And(PluginFilter.GetSpecification()));
		}

		public MainController(
			IFileSearchManager model,
			IMainView view, ISelectPluginController selectPluginController )
		{
			_model = model;
			_view = view;
			_selectPluginController = selectPluginController;

			_view.Controller = this;

			_view.SelectPlugin += SelectPlugin;
			_view.StopSearch += StopSearch;
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

		private void StopSearch(
			object sender,
			EventArgs e )
		{
			if( _model.ResultIsLimited )
				_view.Warning = string.Format( "Shown first {0} find files.", Settings.Default.MaxItemsInSearchResults );
		}

		private void SelectPlugin(
			object sender,
			EventArgs e )
		{
			PluginFilter = _selectPluginController.GetPluginFilter(PluginFilter);
		}
	}
}