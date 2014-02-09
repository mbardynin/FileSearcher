using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.IO;
using System.Linq;

using FileSearcher.Common.Model;
using FileSearcher.GUI.Model.FileWrapper;

namespace FileSearcher.GUI.Model
{
	public class SystemFileSearcher : IFileSearcher
	{
		public IEnumerable<IFileInfo> GetFiles( FileSearchSettings settings )
		{
			Contract.Requires<ArgumentException>( Directory.Exists( settings.Path ), "Directory not exist." );

			var directoryInfo = new DirectoryInfo( settings.Path );
			foreach (var fileInfo in EnumerateFiles(directoryInfo, GetSearchPattern(settings), GetSearchOption(settings)))
			{
				yield return new FileInfoWrapper( fileInfo );
			}
		}

		private static SearchOption GetSearchOption( FileSearchSettings settings )
		{
			return settings.IncludeSubDirectories
				? SearchOption.AllDirectories
				: SearchOption.TopDirectoryOnly;
		}

		private static string GetSearchPattern( FileSearchSettings settings )
		{
			return "*." + settings.FileExtension.ToLower();
		}

		public static IEnumerable<FileInfo> EnumerateFiles(DirectoryInfo directoryInfo, string searchPattern, SearchOption searchOpt)
		{
			try
			{
				var dirFiles = Enumerable.Empty<FileInfo>();
				if (searchOpt == SearchOption.AllDirectories)
				{
					dirFiles = directoryInfo.EnumerateDirectories()
										.SelectMany(x => EnumerateFiles(x, searchPattern, searchOpt));
				}
				return dirFiles.Concat(directoryInfo.EnumerateFiles(searchPattern));
			}
			catch (UnauthorizedAccessException ex)
			{
				return Enumerable.Empty<FileInfo>();
			}
			catch (DirectoryNotFoundException ex)
			{
				return Enumerable.Empty<FileInfo>();
			}
		}
	}
}