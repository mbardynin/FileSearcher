// Mike Bardynin [mikebardynin@gmail.com]

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FileSearcher.Common
{
	public interface IMainView
	{
		void AddFilters( params Control[] filterControls );
		//void SetPluginFilter( SearchControl filter );
		//event Action RefreshPluginList;
		event Action StartSearch;
		void DisplaySearchResult( IEnumerable<IFileInfo> fileInfoList );
	}
}