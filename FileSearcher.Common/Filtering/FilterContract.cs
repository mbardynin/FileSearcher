using System;
using System.Diagnostics.Contracts;

namespace FileSearcher.Common.Filtering
{
	[ ContractClassFor( typeof( IFilter ) ) ]
	public abstract class FilterContract : IFilter
	{
		public bool IsPass( IFileInfo file )
		{
			Contract.Requires<ArgumentNullException>( file != null );
			return default( bool );
		}
	}
}