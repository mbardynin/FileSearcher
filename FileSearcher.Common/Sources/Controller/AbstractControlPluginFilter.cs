using System;
using System.Diagnostics.Contracts;
using System.Windows.Forms;

using FileSearcher.Common.View;

namespace FileSearcher.Common.Controller
{
    public abstract class AbstractControlPluginFilter<TView> : AbstractControlFilter<TView>, IPluginFilter
	    where TView:Control, ISearchFilterView
    {
		protected AbstractControlPluginFilter(TView view): base(view)
		{
			Contract.Requires<ArgumentNullException>(view != null);
        }

		//-------------------------------------------------------------------------------------[]
	    public abstract string Name { get;}
		public abstract string Description { get; }
		public abstract string FileExtension { get;}

		//-------------------------------------------------------------------------------------[]
		public Control UserControl { get { return View; } }
		string IPluginFilter.ToString()
		{
			return string.Format("[{1}] {0}", Name, FileExtension);
		}
    }
}