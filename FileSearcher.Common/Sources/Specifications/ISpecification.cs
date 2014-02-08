// Mike Bardynin [mikebardynin@gmail.com]

using System.Diagnostics.Contracts;

namespace FileSearcher.Common.Specifications
{
	[ ContractClass( typeof( SpecificationContract ) ) ]
	public interface ISpecification
	{
		bool IsSatisfiedBy( IFileInfo file );
	}
}