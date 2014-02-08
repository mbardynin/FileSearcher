// Mike Bardynin [mikebardynin@gmail.com]

using System;
using System.Diagnostics.Contracts;

using FileSearcher.Common;
using FileSearcher.Common.Specifications;

namespace FileSearcher.Core.Model.Specifications
{
	public class DateTimeSpecification : ISpecification
	{
		private readonly Func<IFileInfo, DateTime> _dateTimeGetter;
		private readonly DateTime _maxDate;
		private readonly DateTime _minDate;

		public DateTimeSpecification(
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

		public bool IsSatisfiedBy( IFileInfo file )
		{
			return _dateTimeGetter( file ) >= _minDate && _dateTimeGetter( file ) <= _maxDate;
		}
	}
}