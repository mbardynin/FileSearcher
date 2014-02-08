using System.IO;

using FileSearcher.Common;
using FileSearcher.Common.Specifications;

namespace FileSearcher.Core.Model.Specifications
{
	public class AttributeSpecification : ISpecification
	{
		private readonly FileAttributes _attributes;
		private readonly bool _isIncludeOrExclude;

		public AttributeSpecification( FileAttributes attributes,
			bool isIncludeOrExclude )
		{
			_attributes = attributes;
			_isIncludeOrExclude = isIncludeOrExclude;
		}

		public bool IsSatisfiedBy( IFileInfo file )
		{
			if( _isIncludeOrExclude )
				return ( file.Attributes & _attributes ) == _attributes;
			else
				return (file.Attributes & _attributes) == 0;
		}
	}
}