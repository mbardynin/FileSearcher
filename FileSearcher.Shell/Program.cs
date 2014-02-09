// Mike Bardynin [mikebardynin@gmail.com]

using System;
using System.IO;
using System.Windows.Forms;

namespace FileSearcher.Shell
{
	internal static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[ STAThread ]
		private static void Main()
		{
			CreateDomainWithShadowCopy().ExecuteAssembly( Path.Combine( Application.StartupPath, "FileSearcher.GUI.exe" ) );
		}

		private static AppDomain CreateDomainWithShadowCopy()
		{
			var cachePath = Path.Combine( AppDomain.CurrentDomain.SetupInformation.ApplicationBase, "ShadowCopyCache" );
			var pluginPath = AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
			if( !Directory.Exists( cachePath ) )
				Directory.CreateDirectory( cachePath );

			if( !Directory.Exists( pluginPath ) )
				Directory.CreateDirectory( pluginPath );

			var setup = new AppDomainSetup {
				CachePath = cachePath,
				ShadowCopyFiles = "true",
				ShadowCopyDirectories = pluginPath
			};

			// Create a new AppDomain then create a new instance 
			// of this application in the new AppDomain.            
			return AppDomain.CreateDomain( "Host_AppDomain", AppDomain.CurrentDomain.Evidence, setup );
		}
	}
}