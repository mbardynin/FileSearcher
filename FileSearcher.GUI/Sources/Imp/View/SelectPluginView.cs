// Mike Bardynin [mikebardynin@gmail.com]

using System.Collections.Generic;
using System.Windows.Forms;

using FileSearcher.Common.Controller.Filters;
using FileSearcher.GUI.Pub.View;

namespace FileSearcher.GUI.Imp.View
{
	internal partial class SelectPluginView : Form, ISelectPluginView
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