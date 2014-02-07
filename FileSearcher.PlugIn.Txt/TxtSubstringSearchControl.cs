// Mike Bardynin [mikebardynin@gmail.com]

using System.ComponentModel.Composition;

using FileSearcher.Common;

namespace FileSearcher.PlugIn.Txt
{
	[Export(typeof(SearchControl))]
	public partial class TxtSubstringSearchControl : SearchControl
	{
		public TxtSubstringSearchControl()
		{
			InitializeComponent();
		}

		public override string Text1 { get { return txtSubstring.Text; } }
		public override string PluginName { get { return "TxtSubstringSearch"; } }
	}
}