using System;
using System.Diagnostics.Contracts;

using FileSearcher.Common;

namespace FileSearcher.GUI.Filters.Abstract
{
    public abstract class AbstractControlFilter : AbstractFilter
    {
		protected readonly ISearchFilterView View;  
        public override bool Enabled { get { return View.Enabled; } set { View.Enabled = value; } }

        protected AbstractControlFilter( ISearchFilterView view)
		{
			Contract.Requires<ArgumentNullException>(view != null);
			View = view;
        }
    }
}