// Mike Bardynin [mikebardynin@gmail.com]

using System.Collections.Generic;

using FileSearcher.Common.Controller.Filters;
using FileSearcher.Common.Model;
using FileSearcher.GUI.Interfaces.Model;

namespace FileSearcher.GUI.Interfaces.Controller
{
	public interface IMainController
	{
		IPluginFilter PluginFilter { get; set; }
		IEnumerable<IFileInfo> Search( );
	}
}