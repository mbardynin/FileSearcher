// Mike Bardynin [mikebardynin@gmail.com]

using System;
using System.Diagnostics.Contracts;
using System.IO;

using FileSearcher.Core.FileWrapper;

namespace FileSearcher.Core
{
	[ContractClass(typeof(FilterContract))]
	public interface IFilter
	{
		bool IsPass(IFileInfo file);
	}

	[ContractClassFor(typeof(IFilter))]
	public abstract class FilterContract : IFilter
	{
		public bool IsPass( IFileInfo file )
		{
			Contract.Requires<ArgumentNullException>(file != null);
			return default( bool );
		}
	}

	public class SizeFilter : IFilter
	{
		private long _maxSize;
		private long _minSize;

		public SizeFilter(long? minSize,
			long? maxSize)
		{
			Contract.Requires<ArgumentException>(minSize >= 0);
			Contract.Requires<ArgumentException>(maxSize >= minSize);

			_minSize = minSize ?? 0;
			_maxSize = maxSize ?? long.MaxValue;
		}

		public bool IsPass(IFileInfo file)
		{
			return file.Length >= _minSize && file.Length <= _maxSize;
		}
	}

	public class DateTimeFilter : IFilter
	{
		private readonly Func<IFileInfo, DateTime> _dateTimeGetter;
		private DateTime _maxDate;
		private DateTime _minDate;

		public DateTimeFilter(DateTime? minDate,
			DateTime? maxDate, Func<IFileInfo, DateTime> dateTimeGetter )
		{
			Contract.Requires<ArgumentException>(maxDate >= minDate);
			Contract.Requires<ArgumentException>(dateTimeGetter != null);

			_minDate = minDate ?? DateTime.MinValue;
			_maxDate = maxDate ?? DateTime.MaxValue;
			_dateTimeGetter = dateTimeGetter;
		}

		public bool IsPass(IFileInfo file)
		{
			return _dateTimeGetter(file) >= _minDate && _dateTimeGetter(file) <= _maxDate;
		}
	}
}