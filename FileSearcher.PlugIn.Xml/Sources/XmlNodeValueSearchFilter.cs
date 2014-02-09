// Mike Bardynin [mikebardynin@gmail.com]

using FileSearcher.Common.Controller;
using FileSearcher.Common.Model.Specifications;

namespace FileSearcher.PlugIn.Xml
{
	internal sealed class XmlNodeValueSearchFilter : AbstractControlPluginFilter<XmlNodeValueSearchFilterView>
	{
		public XmlNodeValueSearchFilter( XmlNodeValueSearchFilterView view )
			: base( view ) {}

		protected override ISpecification DoGetFilteringSpecification()
		{
			return new XmlNodeValueSpecification(View.NodeName, View.NodeValue, FileExtension);
		}

		public override string Name { get { return "Xml node value search."; } }
		public override string Description { get { return "Plug-in for search *.xml files with specific value of node."; } }
		public override string FileExtension { get { return "xml"; } }
	}
}