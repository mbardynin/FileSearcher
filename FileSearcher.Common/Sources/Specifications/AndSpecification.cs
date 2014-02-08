// Mike Bardynin [mikebardynin@gmail.com]

using System;
using System.Diagnostics.Contracts;

namespace FileSearcher.Common.Specifications
{
	public class AndSpecification : ISpecification
	{
		private readonly ISpecification Spec1;
		private readonly ISpecification Spec2;

		internal AndSpecification(
			ISpecification s1,
			ISpecification s2 )
		{
			Contract.Requires<ArgumentNullException>( s1 != null );
			Contract.Requires<ArgumentNullException>( s2 != null );
			Spec1 = s1;
			Spec2 = s2;
		}

		public bool IsSatisfiedBy( IFileInfo candidate )
		{
			return Spec1.IsSatisfiedBy( candidate ) && Spec2.IsSatisfiedBy( candidate );
		}
	}
}