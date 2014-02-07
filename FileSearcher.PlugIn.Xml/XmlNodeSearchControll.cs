// Mike Bardynin [mikebardynin@gmail.com]

using System.ComponentModel.Composition;

using FileSearcher.Common;

namespace FileSearcher.PlugIn.Xml
{
	[Export(typeof(SearchControl))]
	public partial class XmlNodeSearchControll : SearchControl
	{
		public XmlNodeSearchControll()
		{
			InitializeComponent();
		}

		public override string Text1 { get { return txtNodeName.Text; } }
		public override string PluginName { get { return "XmlNodeSearch"; } }
	}
}