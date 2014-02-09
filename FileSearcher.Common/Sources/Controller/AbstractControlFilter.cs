using System;
using System.Diagnostics.Contracts;
using System.Windows.Forms;

using FileSearcher.Common.View;

namespace FileSearcher.Common.Controller
{
    public abstract class AbstractControlFilter<TView> : AbstractFilter where TView:Control, ISearchFilterView
    {
		protected readonly TView View;  
        public override bool Enabled { get { return View.Enabled; } set { View.Enabled = value; } }

		protected AbstractControlFilter(TView view)
		{
			Contract.Requires<ArgumentNullException>(view != null);
			View = view;
        }
    }
}