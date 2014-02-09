// Mike Bardynin [mikebardynin@gmail.com]

using FileSearcher.Common.Controller;
using FileSearcher.Common.Model.Specifications;

namespace FileSearcher.PlugIn.Txt
{
	internal sealed class TxtSubstringSearchFilter : AbstractControlPluginFilter<TxtSubstringSearchFilterView>
	{
		public TxtSubstringSearchFilter( TxtSubstringSearchFilterView view )
			: base( view ) {}

		protected override ISpecification DoGetFilteringSpecification()
		{
			return new SubstringSpecification( View.Substring, FileExtension );
		}

		public override string Name { get { return "Substring search"; } }
		public override string Description { get { return "Plug-in for search *.txt files with specific substring."; } }
		public override string FileExtension { get { return "txt"; } }
	}
}