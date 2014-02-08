// Mike Bardynin [mikebardynin@gmail.com]

using System.Diagnostics.Contracts;

namespace FileSearcher.Common.Filtering
{
	[ ContractClass( typeof( SpecificationContract ) ) ]
	public interface ISpecification
	{
		bool IsSatisfiedBy( IFileInfo file );
	}
}