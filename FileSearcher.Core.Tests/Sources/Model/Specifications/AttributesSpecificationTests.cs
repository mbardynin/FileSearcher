// Mike Bardynin [mikebardynin@gmail.com]

using System;
using System.Collections;
using System.IO;

using FileSearcher.Common.Model;
using FileSearcher.GUI.Implementations.Model.Specifications;

using Moq;

using NUnit.Framework;

namespace FileSearcher.Core.Tests.Filters
{
	[ TestFixture ]
	public class AttributesSpecificationTests
	{
		[ TestCaseSource( "TestCases" ) ]
		public bool Test(
			FileAttributes attributes,
			bool isIncludeOrExclude,
			IFileInfo fileInfo )
		{
			return new AttributeSpecification( attributes, isIncludeOrExclude ).IsSatisfiedBy( fileInfo );
		}

		private static IFileInfo GetFileInfo( FileAttributes attributes )
		{
			var fileInfoMock = new Mock<IFileInfo>();
			fileInfoMock.SetupGet( x => x.Attributes ).Returns( attributes );
			return fileInfoMock.Object;
		}

		public static IEnumerable TestCases
		{
			get
			{
				yield return
					new TestCaseData( FileAttributes.Archive, true, GetFileInfo( FileAttributes.Archive | FileAttributes.Compressed ) )
						.Returns( true ).SetName( "Attribute includes." );
				yield return
					new TestCaseData( FileAttributes.Archive, true, GetFileInfo( FileAttributes.Device | FileAttributes.Compressed ) )
						.Returns( false ).SetName( "Attribute not includes." );
				yield return
					new TestCaseData(
						FileAttributes.Archive | FileAttributes.Compressed,
						true,
						GetFileInfo( FileAttributes.Archive | FileAttributes.Compressed ) ).Returns( true ).SetName( "Attribute equals." )
					;

				yield return
					new TestCaseData( FileAttributes.Archive | FileAttributes.Compressed, false, GetFileInfo( FileAttributes.Device ) )
						.Returns( true ).SetName( "Attribute excludes." );
				yield return
					new TestCaseData(
						FileAttributes.Archive | FileAttributes.Compressed,
						false,
						GetFileInfo( FileAttributes.Archive ) ).Returns( false ).SetName( "Attribute not excludes." );
				yield return
					new TestCaseData( FileAttributes.Archive, true, null ).Throws( typeof( ArgumentNullException ) )
						.SetName( "FileInfo is null." );
			}
		}
	}
}