using FileSearcher.Common.Controller;

namespace FileSearcher.GUI.Controller
{
	public interface ISelectPluginController {
		IPluginFilter GetPluginFilter( IPluginFilter oldPluginFilter );
	}
}