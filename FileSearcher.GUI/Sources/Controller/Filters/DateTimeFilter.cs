// Mike Bardynin [mikebardynin@gmail.com]

using System;
using System.Diagnostics.Contracts;
using System.Linq.Expressions;

using FileSearcher.Common.Controller;
using FileSearcher.Common.Model;
using FileSearcher.Common.Model.Specifications;
using FileSearcher.GUI.Controls.Sources;
using FileSearcher.GUI.Model.Specifications;

namespace FileSearcher.GUI.Controller.Filters
{
	internal sealed class DateTimeFilter : AbstractControlFilter
	{
		private readonly DateTimeSearchFilterView _view;
		private readonly Func<IFileInfo, DateTime> _dateTimeGetter;

		public DateTimeFilter(DateTimeSearchFilterView view,
			Expression<Func<IFileInfo, DateTime>> dateTimeGetter)
			: base( view )
		{
			Contract.Requires<ArgumentNullException>(dateTimeGetter != null);
			_view = view;
			_dateTimeGetter = dateTimeGetter.Compile();
			var expression = (MemberExpression)dateTimeGetter.Body;
			string name = expression.Member.Name;
			_view.Text = name;
		}

		protected override ISpecification DoGetFilteringSpecification()
		{
			return new DateTimeSpecification( _view.DateFrom, _view.DateTo, _dateTimeGetter );
		}
	}
}