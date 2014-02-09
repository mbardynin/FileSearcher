// Mike Bardynin [mikebardynin@gmail.com]

using System.ComponentModel.Composition;

using FileSearcher.Common;
using FileSearcher.Common.Controller;
using FileSearcher.Common.Model.Specifications;

namespace FileSearcher.PlugIn.Xml
{
	[Export(typeof(IPluginFilter))]
	public sealed class XmlNodeValueSearchFilter : AbstractControlPluginFilter<XmlNodeValueSearchFilterView>
	{
		protected override ISpecification DoGetFilteringSpecification()
		{
			if (View.NodeName.IsNullOrEmpty() || View.NodeValue.IsNullOrEmpty())
				return new NullSpecification();
			return new XmlNodeValueSpecification(View.NodeName, View.NodeValue, FileExtension);
		}

		public override string Name { get { return "Xml node value search."; } }
		public override string Description { get { return "Plug-in for search *.xml files with specific value of node."; } }
		public override string FileExtension { get { return "xml"; } }
	}
}