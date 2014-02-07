// Mike Bardynin [mikebardynin@gmail.com]

using System.Diagnostics.Contracts;

namespace FileSearcher.Common.Filtering
{
	[ ContractClass( typeof( FilterContract ) ) ]
	public interface IFilter
	{
		bool IsPass( IFileInfo file );
	}
}