﻿namespace FileSearcher.Core
{
	public class FileSearchSettings
	{
		public string Path { get; set; }
		public string FileExtension { get; set; }
		public bool IncludeSubDirectories { get; set; }
	}
}