// Mike Bardynin [mikebardynin@gmail.com]

using System.Windows.Forms;

using FileSearcher.Common.View;

namespace FileSearcher.PlugIn.Xml
{
	public partial class XmlNodeValueSearchFilterView : UserControl, ISearchFilterView
	{
		public string NodeName { get { return txtNodeName.Text; } }
		public string NodeValue { get { return txtValue.Text; } }

		bool ISearchFilterView.Enabled{ get { return chbEnabled.Checked; } set { chbEnabled.Checked = value; } }

		public XmlNodeValueSearchFilterView(  )
		{
			InitializeComponent();
			bsEnabled.Add( chbEnabled );
		}
	}
}