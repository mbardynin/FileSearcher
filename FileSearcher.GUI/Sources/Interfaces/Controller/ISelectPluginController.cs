using FileSearcher.Common.Controller.Filters;

namespace FileSearcher.GUI.Interfaces.Controller
{
	public interface ISelectPluginController {
		IPluginFilter GetPluginFilter( IPluginFilter oldPluginFilter );
	}
}