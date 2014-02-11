// Mike Bardynin [mikebardynin@gmail.com]

using System.Collections.Generic;

using FileSearcher.Common.Controller.Filters;
using FileSearcher.Common.Model;

namespace FileSearcher.GUI.Pub.Controller
{
	public interface IMainController
	{
		IPluginFilter PluginFilter { get; set; }
		IEnumerable<IFileInfo> Search( );
	}
}