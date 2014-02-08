// Mike Bardynin [mikebardynin@gmail.com]

using System;
using System.Collections;

using FileSearcher.Common;
using FileSearcher.Core.Model.Specifications;

using Moq;

using NUnit.Framework;

namespace FileSearcher.Core.Tests.Filters
{
	[ TestFixture ]
	public class SizeFilterTests
	{
		[ TestCaseSource( "TestCases" ) ]
		public bool Test(
			long? minSize,
			long? maxSize,
			IFileInfo fileInfo )
		{
			return new SizeSpecification( minSize, maxSize ).IsSatisfiedBy( fileInfo );
		}

		private static IFileInfo GetFileInfo( long size )
		{
			var fileInfoMock = new Mock<IFileInfo>();
			fileInfoMock.SetupGet( x => x.Length ).Returns( size );
			return fileInfoMock.Object;
		}

		public static IEnumerable TestCases
		{
			get
			{
				yield return
					new TestCaseData( -1L, 1L, GetFileInfo( 5 ) ).Throws( typeof( ArgumentException ) )
						.SetName( "MinSize is less zero." );
				yield return
					new TestCaseData( 1L, -1L, GetFileInfo( 5 ) ).Throws( typeof( ArgumentException ) )
						.SetName( "MaxSize is less zero." );
				yield return
					new TestCaseData( 10L, 1L, GetFileInfo( 5 ) ).Throws( typeof( ArgumentException ) )
						.SetName( "MaxSize is less than MinSize." );

				yield return new TestCaseData( null, 6L, GetFileInfo( 0 ) ).Returns( true ).SetName( "MinSize is null." );
				yield return
					new TestCaseData( 5L, null, GetFileInfo( long.MaxValue ) ).Returns( true ).SetName( "MaxSize is null." );

				yield return new TestCaseData( 2L, 6L, GetFileInfo( 5 ) ).Returns( true ).SetName( "Size is between bounds." );
				yield return new TestCaseData( 2L, 2L, GetFileInfo( 2 ) ).Returns( true ).SetName( "Size is on bounds." );
				yield return new TestCaseData( 2L, 6L, GetFileInfo( 10 ) ).Returns( false ).SetName( "Size is greater bounds." );
				yield return new TestCaseData( 2L, 6L, GetFileInfo( 1 ) ).Returns( false ).SetName( "Size is less bounds." );
				yield return
					new TestCaseData( 1L, 2L, null ).Throws( typeof( ArgumentNullException ) ).SetName( "FileInfo is null." );
			}
		}
	}
}