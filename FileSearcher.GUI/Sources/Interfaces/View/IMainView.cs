// Mike Bardynin [mikebardynin@gmail.com]

using System;
using System.Windows.Forms;

using FileSearcher.GUI.Interfaces.Controller;

namespace FileSearcher.GUI.Interfaces.View
{
	public interface IMainView
	{
		void AddFilters( params Control[] filterControls );

		string Warning { get; set; }
		string Status { get; set; }
		IMainController Controller { get; set; }
		bool IncludeSubDirectories { get; set; }
		string StartPath { get; set; }

		event EventHandler SelectPlugin;
		event EventHandler StopSearch;
	}
}