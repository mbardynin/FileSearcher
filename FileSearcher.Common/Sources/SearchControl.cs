// Mike Bardynin [mikebardynin@gmail.com]

using System.Windows.Forms;

namespace FileSearcher.Common
{
	public abstract class SearchControl : UserControl
	{
		public abstract string Text1 { get; }
		public abstract string PluginName { get; }
	}
}