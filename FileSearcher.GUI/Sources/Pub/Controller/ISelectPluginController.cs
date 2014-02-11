using FileSearcher.Common.Controller.Filters;

namespace FileSearcher.GUI.Pub.Controller
{
	public interface ISelectPluginController {
		IPluginFilter GetPluginFilter( IPluginFilter oldPluginFilter );
	}
}