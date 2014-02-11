// Mike Bardynin [mikebardynin@gmail.com]

using System.Collections.Generic;

using FileSearcher.Common.Model;

namespace FileSearcher.GUI.Pub.Model
{
	public interface IFileSearcher
	{
		IEnumerable<IFileInfo> GetFiles( FileSearchSettings settings );
	}
}