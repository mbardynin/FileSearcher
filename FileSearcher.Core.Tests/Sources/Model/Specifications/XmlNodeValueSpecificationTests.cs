// Mike Bardynin [mikebardynin@gmail.com]

using System.Collections;
using System.IO;
using System.Text;

using FileSearcher.Common.Model;
using FileSearcher.PlugIn.Xml;

using Moq;

using NUnit.Framework;

namespace FileSearcher.Core.Tests.Filters
{
	[ TestFixture ]
	public class XmlNodeValueSpecificationTests
	{
		[ TestCaseSource( "TestCases" ) ]
		public bool Test(
			string name,
			string value,
			string extension,
			IFileInfo fileInfo )
		{
			return new XmlNodeValueSpecification( name, value, extension ).IsSatisfiedBy( fileInfo );
		}

		private static IFileInfo GetFileInfo(
			string extension,
			string text )
		{
			var fileInfoMock = new Mock<IFileInfo>();
			fileInfoMock.SetupGet( x => x.Extension ).Returns( extension );
			fileInfoMock.Setup( x => x.OpenText() )
				.Returns( () => new StreamReader( new MemoryStream( Encoding.UTF8.GetBytes( text ) ) ) );
			return fileInfoMock.Object;
		}

		public static IEnumerable TestCases
		{
			get
			{
				yield return
					new TestCaseData("node1", "q", "xml", GetFileInfo(".xml", validXml)).Returns(false).SetName("Don't contains node with value.");
				yield return
					new TestCaseData("node1", "rrr", "xml", GetFileInfo(".xml", validXml)).Returns(true).SetName("Contains node with value.");
				yield return
					new TestCaseData("node2", "www", "xml", GetFileInfo(".xml", validXml)).Returns(true).SetName("Contains node with value and attributes.");
				yield return
					new TestCaseData("node2", "www", "txt", GetFileInfo(".xml", validXml)).Returns(false).SetName("Wrong file extension.");
				yield return
					new TestCaseData("node1", "rrr", "xml", GetFileInfo(".xml", invalidXml)).Returns(false).SetName("Contains node with value in invalide xml.");

			}
		}

		private static string validXml = @"<root><node1>rrr</node1><node2>qqq</node2><node2 attr=""q"">www</node2></root>";
		private static string invalidXml = @"<root1></root1><root><node1>rrr</node1><node2>qqq</node2><node2 attr=""q"">www</node2></root>";
	}
}