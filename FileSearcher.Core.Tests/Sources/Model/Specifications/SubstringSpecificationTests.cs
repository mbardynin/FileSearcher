// Mike Bardynin [mikebardynin@gmail.com]

using System.Collections;
using System.IO;
using System.Text;

using FileSearcher.Common.Model;
using FileSearcher.GUI.Controller.Filters;
using FileSearcher.PlugIn.Txt;

using Moq;

using NUnit.Framework;

namespace FileSearcher.Core.Tests.Filters
{
	[TestFixture]
	public class SubstringSpecificationTests
	{
		[ TestCaseSource( "TestCases" ) ]
		public bool Test(
			string substring,
			string extension,
			IFileInfo fileInfo )
		{
			return new SubstringSpecification(substring, extension).IsSatisfiedBy(fileInfo);
		}

		private static IFileInfo GetFileInfo( string extension, string text )
		{
			var fileInfoMock = new Mock<IFileInfo>();
			fileInfoMock.SetupGet(x => x.Extension).Returns(extension);
			fileInfoMock.Setup(x => x.OpenText()).Returns(() => new StreamReader(new MemoryStream(Encoding.UTF8.GetBytes( text))));
			return fileInfoMock.Object;
		}

		public static IEnumerable TestCases
		{
			get
			{
				yield return
					new TestCaseData("a", "txt", GetFileInfo(".txt", "qeqwe"))
						.Returns(false).SetName("Don't contains substring.");
				yield return
					new TestCaseData("aq", "txt", GetFileInfo(".txt", "qeaqwe"))
						.Returns(true).SetName("Contains substring.");
				yield return
					new TestCaseData("aq", "txt", GetFileInfo(".xml", "qeaqwe"))
						.Returns(false).SetName("Wrong file extension.");
				
			}
		}
	}
}