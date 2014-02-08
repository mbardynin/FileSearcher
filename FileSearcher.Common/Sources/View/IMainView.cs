// Mike Bardynin [mikebardynin@gmail.com]

using System;
using System.Collections.Generic;
using System.Windows.Forms;

using FileSearcher.Common.Model;

namespace FileSearcher.Common.View
{
	public interface IMainView
	{
		void AddFilters( params Control[] filterControls );
		void DisplaySearchResult( IEnumerable<IFileInfo> fileInfoList );
		FileSearchSettings GetMainSettings();

		string Warning { get; set; }
		string Status { get; set; }

		event EventHandler StartSearch;
	}
}