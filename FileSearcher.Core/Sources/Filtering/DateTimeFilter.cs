using System;
using System.Diagnostics.Contracts;

using FileSearcher.Common;
using FileSearcher.Common.Filtering;
using FileSearcher.Core.FileWrapper;

namespace FileSearcher.Core
{
	public class DateTimeFilter : IFilter
	{
		private readonly Func<IFileInfo, DateTime> _dateTimeGetter;
		private readonly DateTime _maxDate;
		private readonly DateTime _minDate;

		public DateTimeFilter(
			DateTime? minDate,
			DateTime? maxDate,
			Func<IFileInfo, DateTime> dateTimeGetter )
		{
			Contract.Requires<ArgumentException>( ( maxDate ?? DateTime.MaxValue ) >= ( minDate ?? DateTime.MinValue ) );
			Contract.Requires<ArgumentException>( dateTimeGetter != null );

			_minDate = minDate ?? DateTime.MinValue;
			_maxDate = maxDate ?? DateTime.MaxValue;
			_dateTimeGetter = dateTimeGetter;
		}

		public bool IsPass( IFileInfo file )
		{
			return _dateTimeGetter( file ) >= _minDate && _dateTimeGetter( file ) <= _maxDate;
		}
	}
}