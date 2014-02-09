// Mike Bardynin [mikebardynin@gmail.com]

using System;
using System.Diagnostics.Contracts;

using FileSearcher.Common;
using FileSearcher.Common.Model;
using FileSearcher.Common.Model.Specifications;

namespace FileSearcher.PlugIn.Txt
{
	public class SubstringSpecification : ISpecification
	{
		private readonly string _fileExtension;
		private readonly string _substring;

		public SubstringSpecification(
			string substring,
			string fileExtension )
		{
			Contract.Requires<ArgumentException>( substring.IsNotEmpty() );
			Contract.Requires<ArgumentException>(fileExtension.IsNotEmpty());
			_substring = substring;
			_fileExtension = fileExtension;
		}

		public bool IsSatisfiedBy( IFileInfo file )
		{
			if(file.Extension.Replace(".","").ToLower() != _fileExtension )
				return false;

			var line = "";
			try {
				using( var sr = file.OpenText() ) {
					while( ( line = sr.ReadLine() ) != null ) {
						if( line.Contains( _substring ) )
							return true;
					}
				}
			}
			catch( Exception ) {
				return false;
			}
			return false;
		}
	}
}