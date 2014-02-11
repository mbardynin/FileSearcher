// Mike Bardynin [mikebardynin@gmail.com]

using System.Collections.Generic;

using FileSearcher.Common.Controller.Filters;
using FileSearcher.Common.Model;
using FileSearcher.GUI.Model;

namespace FileSearcher.GUI.Controller
{
	public interface IMainController
	{
		IPluginFilter PluginFilter { get; set; }
		IEnumerable<IFileInfo> Search( FileSearchSettings fileSearchSettings );
	}
}