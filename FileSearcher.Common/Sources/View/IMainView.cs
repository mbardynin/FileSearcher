// Mike Bardynin [mikebardynin@gmail.com]

using System;
using System.Windows.Forms;

using FileSearcher.Common.Controller;

namespace FileSearcher.Common.View
{
	public interface IMainView
	{
		void AddFilters( params Control[] filterControls );

		string Warning { get; set; }
		string Status { get; set; }
		IMainController Controller { get; set; }

		event EventHandler SelectPlugin;
		event EventHandler StopSearch;
	}
}