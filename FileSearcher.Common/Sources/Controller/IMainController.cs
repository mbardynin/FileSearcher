using System.Collections.Generic;

using FileSearcher.Common.Model;

namespace FileSearcher.Common.Controller
{
	public interface IMainController {
		IPluginFilter PluginFilter { get; set; }
		IEnumerable<IFileInfo> Search( FileSearchSettings fileSearchSettings );
	}
}