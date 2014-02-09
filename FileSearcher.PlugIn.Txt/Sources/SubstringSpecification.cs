// Mike Bardynin [mikebardynin@gmail.com]

using System;
using System.Diagnostics.Contracts;
using System.IO;

using FileSearcher.Common.Model;
using FileSearcher.Common.Model.Specifications;

namespace FileSearcher.PlugIn.Txt
{
	public class SubstringSpecification : ISpecification
	{
		private readonly string _fileExtension;
		private readonly string _substring;

		public SubstringSpecification(
			string substring, string fileExtension = "txt")
		{
			Contract.Requires<ArgumentException>(!string.IsNullOrEmpty(substring));
			Contract.Requires<ArgumentException>(!string.IsNullOrEmpty(fileExtension));
			_substring = substring;
			_fileExtension = fileExtension;
		}

		public bool IsSatisfiedBy( IFileInfo file )
		{
			int maxFileSize = 100 * 1024 * 1024;
			if (file.Length > maxFileSize || file.Extension.ToLower() != _fileExtension)
			{
				return false;
			}

			string line = "";
			using (StreamReader sr = file.OpenText())
			{
				while ((line = sr.ReadLine()) != null)
				{
					if( line.Contains(_substring) ) {
						return true;
					}
				}
			}
			return false;
		}
	}
}