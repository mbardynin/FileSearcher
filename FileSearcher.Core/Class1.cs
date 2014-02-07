using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSearcher.Core
{
    public class FileSearchManager
    {
	    private IFileSearcher _fileSearcher;
	    private readonly int _maxFilesInSearchResults;

	    public FileSearchManager( IFileSearcher fileSearcher,
		    int maxFilesInSearchResults )
	    {
		    _fileSearcher = fileSearcher;
		    _maxFilesInSearchResults = maxFilesInSearchResults;
		    var directory = new DirectoryInfo( "path" );
	    }

	    IEnumerable<FileInfo> Search(
		    FileSearchSettings settings,
		    IEnumerable<IFilter> filters )
	    {
		    var filtersList = filters.ToList();
			foreach (var file in _fileSearcher.GetFiles(settings).Take(_maxFilesInSearchResults)) {
				if( filtersList.All( filter => filter.IsPass( file ) ) )
					yield return file;
			}
	    }
    }

	public class FileSearchSettings
	{
		public string Path { get; set; }
		public bool IncludeSubDirectories { get; set; }
	}

	public interface IFileSearcher
	{
		IEnumerable<FileInfo> GetFiles( FileSearchSettings settings );
	}
}
