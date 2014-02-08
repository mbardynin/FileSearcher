// Mike Bardynin [mikebardynin@gmail.com]

using System.Windows.Forms;

using FileSearcher.Core.Controller;

namespace FileSearcher.Core.Sources.View.Controls
{
	public partial class BaseSearchFilterView : UserControl
	{
		protected readonly ISearchFilterController Controller;

		public BaseSearchFilterView( ISearchFilterController controller )
		{
			Controller = controller;
			InitializeComponent();
		}
	}
}