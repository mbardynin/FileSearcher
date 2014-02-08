// Mike Bardynin [mikebardynin@gmail.com]

using System.Collections.Generic;
using System.Linq;

using FileSearcher.Common;
using FileSearcher.Common.Specifications;

namespace FileSearcher.Core.Model
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
		}

		public IEnumerable<IFileInfo> Search(
			FileSearchSettings settings,
			ISpecification filter )
		{
			ResultIsLimited = false;
			var i = 0;
			foreach( var file in _fileSearcher.GetFiles( settings ).Take( _maxFilesInSearchResults + 1 ) ) {
				if( filter.IsSatisfiedBy( file ) ) {
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