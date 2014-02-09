using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileSearcher.Shell
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			SetupShadowCopy();
			domain.ExecuteAssembly(Path.Combine(Application.StartupPath, "FileSearcher.GUI.exe"));
		}
		internal static AppDomain domain;
		private static void SetupShadowCopy()
		{
			var cachePath = Path.Combine(AppDomain.CurrentDomain.SetupInformation.ApplicationBase, "ShadowCopyCache");
			var pluginPath = AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
			if (!Directory.Exists(cachePath))
				Directory.CreateDirectory(cachePath);

			if (!Directory.Exists(pluginPath))
				Directory.CreateDirectory(pluginPath);

			var setup = new AppDomainSetup
			{
				CachePath = cachePath,
				ShadowCopyFiles = "true",
				ShadowCopyDirectories = pluginPath
			};

			// Create a new AppDomain then create a new instance 
			// of this application in the new AppDomain.            
			domain = AppDomain.CreateDomain("Host_AppDomain", AppDomain.CurrentDomain.Evidence, setup);
		}
	}
}
