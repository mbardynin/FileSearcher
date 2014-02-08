// Mike Bardynin [mikebardynin@gmail.com]

using System;
using System.Diagnostics.Contracts;

namespace FileSearcher.Common.Model.Specifications
{
	[ ContractClassFor( typeof( ISpecification ) ) ]
	public abstract class SpecificationContract : ISpecification
	{
		public bool IsSatisfiedBy( IFileInfo file )
		{
			Contract.Requires<ArgumentNullException>( file != null );
			return default( bool );
		}
	}
}