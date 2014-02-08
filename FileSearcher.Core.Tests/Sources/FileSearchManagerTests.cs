// Mike Bardynin [mikebardynin@gmail.com]

using System.Linq;

using FileSearcher.Common;
using FileSearcher.Common.Filtering;

using Moq;

using NUnit.Framework;

namespace FileSearcher.Core.Tests
{
	[ TestFixture ]
	public class FileSearchManagerTests
	{
		private MockRepository _mockContainer;
		private Mock<IFileSearcher> _fileSearcherMock;
		private Mock<IFileInfo> _fileInfoMock;
		private Mock<ISpecification> _filterMock;

		[ SetUp ]
		public void Setup()
		{
			_mockContainer = new MockRepository( MockBehavior.Strict );
			_fileSearcherMock = _mockContainer.Create<IFileSearcher>();
			_filterMock = _mockContainer.Create<ISpecification>();
			_fileInfoMock = _mockContainer.Create<IFileInfo>();
		}

		[ Test ]
		public void Search_VerifyAllExpectedCalls()
		{
			// Arrange
			_filterMock.Setup( f => f.IsSatisfiedBy( It.IsAny<IFileInfo>() ) ).Returns( true );
			_fileSearcherMock.Setup( x => x.GetFiles( It.IsAny<FileSearchSettings>() ) )
				.Returns( new[] {_fileInfoMock.Object} )
				.Verifiable();

			var manager = new FileSearchManager( _fileSearcherMock.Object, 100 );

			// Act
			var result = manager.Search( new FileSearchSettings(), new[] {_filterMock.Object} ).ToList();

			// Assert
			_mockContainer.VerifyAll();
		}

		[ Test ]
		public void Search_CheckFiltering()
		{
			// Arrange
			_filterMock.Setup( f => f.IsSatisfiedBy( It.IsAny<IFileInfo>() ) ).Returns( false );
			_fileSearcherMock.Setup( x => x.GetFiles( It.IsAny<FileSearchSettings>() ) )
				.Returns( new[] {_fileInfoMock.Object} )
				.Verifiable();

			var manager = new FileSearchManager( _fileSearcherMock.Object, 100 );

			// Act
			var result = manager.Search( new FileSearchSettings(), new[] {_filterMock.Object} ).ToList();

			// Assert
			Assert.AreEqual( 0, result.Count );
			Assert.IsFalse( manager.ResultIsLimited );
		}

		[ Test ]
		public void Search_CheckFilesLimit()
		{
			// Arrange
			_filterMock.Setup( f => f.IsSatisfiedBy( It.IsAny<IFileInfo>() ) ).Returns( true );
			_fileSearcherMock.Setup( x => x.GetFiles( It.IsAny<FileSearchSettings>() ) )
				.Returns( new[] {_fileInfoMock.Object, _fileInfoMock.Object} )
				.Verifiable();

			var manager = new FileSearchManager( _fileSearcherMock.Object, 1 );

			// Act
			var result = manager.Search( new FileSearchSettings(), new[] {_filterMock.Object} ).ToList();

			// Assert
			Assert.AreEqual( 1, result.Count );
			Assert.IsTrue( manager.ResultIsLimited );
		}
	}
}