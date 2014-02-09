// Mike Bardynin [mikebardynin@gmail.com]

using System.Collections.Generic;
using System.Windows.Forms;

using FileSearcher.Common.Controller;

namespace FileSearcher.GUI.View
{
	public partial class SelectPluginView : Form, ISelectPluginView
	{
		public SelectPluginView()
		{
			InitializeComponent();
		}

		public void SetPluginsList( IEnumerable<IPluginFilter> plugins )
		{
			iPluginFilterBindingSource.DataSource = plugins;
		}

		public IPluginFilter SelectedPlugin { get { return iPluginFilterBindingSource.Current as IPluginFilter; } }
	}
}