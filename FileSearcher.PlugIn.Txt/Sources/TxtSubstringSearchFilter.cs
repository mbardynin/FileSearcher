// Mike Bardynin [mikebardynin@gmail.com]

using System.ComponentModel.Composition;

using FileSearcher.Common;
using FileSearcher.Common.Controller;
using FileSearcher.Common.Controller.Filters;
using FileSearcher.Common.Model.Specifications;

namespace FileSearcher.PlugIn.Txt
{
	[Export(typeof(IPluginFilter))]
	public sealed class TxtSubstringSearchFilter : AbstractControlPluginFilter<TxtSubstringSearchFilterView>
	{
		protected override ISpecification DoGetFilteringSpecification()
		{
			if (View.Substring.IsNullOrEmpty())
				return new NullSpecification();
			return new SubstringSpecification( View.Substring, FileExtension );
		}

		public override string Name { get { return "Substring search"; } }
		public override string Description { get { return "Plug-in for search *.txt files with specific substring."; } }
		public override string FileExtension { get { return "txt"; } }
	}
}