// Mike Bardynin [mikebardynin@gmail.com]

using FileSearcher.Common.Specifications;
using FileSearcher.Core.Model.Specifications;
using FileSearcher.GUI.Controls.Sources;
using FileSearcher.GUI.Filters.Abstract;

namespace FileSearcher.GUI.Filters.Impl
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