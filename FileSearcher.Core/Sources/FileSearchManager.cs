// Mike Bardynin [mikebardynin@gmail.com]

using System.Collections.Generic;
using System.Linq;

using FileSearcher.Common;
using FileSearcher.Common.Filtering;

namespace FileSearcher.Core
{
	public class FileSearchManager
	{
		private readonly IFileSearcher _fileSearcher;
		private readonly int _maxFilesInSearchResults;

		public FileSearchManager(
			IFileSearcher fileSearcher,
			int maxFilesInSearchResults )
		{
			_fileSearcher = fileSearcher;
			_maxFilesInSearchResults = maxFilesInSearchResults;
			//var directory = new DirectoryInfo( "path" );
		}

		public IEnumerable<IFileInfo> Search(
			FileSearchSettings settings,
			IEnumerable<IFilter> filters )
		{
			var filtersList = filters.ToList();
			ResultIsLimited = false;
			var i = 0;
			foreach( var file in _fileSearcher.GetFiles( settings ).Take( _maxFilesInSearchResults + 1 ) ) {
				if( filtersList.All( filter => filter.IsPass( file ) ) ) {
					if( ++i <= _maxFilesInSearchResults )
						yield return file;

					ResultIsLimited = true;
					yield break;
				}
			}
		}

		public bool ResultIsLimited { get; private set; }
	}
}