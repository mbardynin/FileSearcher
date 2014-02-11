// Mike Bardynin [mikebardynin@gmail.com]

using System.Windows.Forms;

using FileSearcher.Common.View;

namespace FileSearcher.Common.Controller.Filters
{
	public abstract class AbstractControlPluginFilter< TView > : AbstractControlFilter<TView>, IPluginFilter
		where TView : Control, ISearchFilterView, new()
	{
		protected AbstractControlPluginFilter()
			: base( new TView() ) {}

		//-------------------------------------------------------------------------------------[]
		public abstract string Name { get; }
		public abstract string Description { get; }
		public abstract string FileExtension { get; }

		//-------------------------------------------------------------------------------------[]
		public Control UserControl { get { return View; } }

		string IPluginFilter.ToString()
		{
			return string.Format( "[{1}] {0}", Name, FileExtension );
		}
	}
}