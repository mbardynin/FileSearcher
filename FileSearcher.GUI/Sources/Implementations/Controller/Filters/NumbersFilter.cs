// Mike Bardynin [mikebardynin@gmail.com]

using FileSearcher.Common.Controller;
using FileSearcher.Common.Controller.Filters;
using FileSearcher.Common.Model.Specifications;
using FileSearcher.GUI.Controls.Sources;
using FileSearcher.GUI.Model.Specifications;

namespace FileSearcher.GUI.Controller.Filters
{
	internal sealed class NumbersFilter : AbstractControlFilter<FileSizeSearchFilterView>
	{
		public NumbersFilter( FileSizeSearchFilterView view )
			: base( view )
		{
		}

		protected override ISpecification DoGetFilteringSpecification()
		{
			return new SizeSpecification(View.MinSize * 1024, View.MaxSize * 1024);
		}
	}
}