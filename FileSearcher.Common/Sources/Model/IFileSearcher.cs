// Mike Bardynin [mikebardynin@gmail.com]

using System.Collections.Generic;

namespace FileSearcher.Common.Model
{
	public interface IFileSearcher
	{
		IEnumerable<IFileInfo> GetFiles( FileSearchSettings settings );
	}
}