// Mike Bardynin [mikebardynin@gmail.com]

using System;
using System.Diagnostics.Contracts;

using FileSearcher.Common;
using FileSearcher.Common.Filtering;

namespace FileSearcher.Core.Filtering
{
	public class SizeFilter : IFilter
	{
		private readonly long _maxSize;
		private readonly long _minSize;

		public SizeFilter(
			long? minSize,
			long? maxSize )
		{
			Contract.Requires<ArgumentException>( ( minSize ?? 0 ) >= 0 );
			Contract.Requires<ArgumentException>( ( maxSize ?? long.MaxValue ) >= ( minSize ?? 0 ) );

			_minSize = minSize ?? 0;
			_maxSize = maxSize ?? long.MaxValue;
		}

		public bool IsPass( IFileInfo file )
		{
			return file.Length >= _minSize && file.Length <= _maxSize;
		}
	}
}