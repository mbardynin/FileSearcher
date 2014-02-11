// Mike Bardynin [mikebardynin@gmail.com]

using System;
using System.Windows.Forms;

using FileSearcher.GUI.Pub.Controller;

namespace FileSearcher.GUI.Pub.View
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