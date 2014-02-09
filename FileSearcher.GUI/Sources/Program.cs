// Mike Bardynin [mikebardynin@gmail.com]

using System;
using System.Windows.Forms;

using FileSearcher.GUI.Controller;
using FileSearcher.GUI.Model;
using FileSearcher.GUI.View;

namespace FileSearcher.GUI
{
	internal static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[ STAThread ]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault( false );

			var mainView = new MainView();
			var model = new FileSearchManager( new SystemFileSearcher(), Properties.Settings.Default.MaxItemsInSearchResults );
			var selectPluginController = new SelectPluginController();
			var mainController = new MainController( model, mainView,  selectPluginController );

			Application.Run( mainView );
		}
	}
}