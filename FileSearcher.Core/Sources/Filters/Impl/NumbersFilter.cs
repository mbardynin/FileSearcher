// Mike Bardynin [mikebardynin@gmail.com]

using FileSearcher.Common.Specifications;
using FileSearcher.Core.Filters.Abstract;
using FileSearcher.Core.Model.Specifications;
using FileSearcher.Core.Sources.View.Controls;

namespace FileSearcher.Core.Filters.Impl
{
	internal sealed class NumbersFilter : AbstractControlFilter
	{
		private readonly FileSizeSearchFilterView _view;

		public NumbersFilter( FileSizeSearchFilterView view )
			: base( view )
		{
			_view = view;
		}

		protected override ISpecification DoGetFilteringSpecification()
		{
			return new SizeSpecification( _view.MinSize*1024, _view.MaxSize*1024 );
		}
	}
}