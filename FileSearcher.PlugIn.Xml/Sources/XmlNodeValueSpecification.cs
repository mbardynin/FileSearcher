// Mike Bardynin [mikebardynin@gmail.com]

using System;
using System.Diagnostics.Contracts;
using System.Xml;

using FileSearcher.Common;
using FileSearcher.Common.Model;
using FileSearcher.Common.Model.Specifications;

namespace FileSearcher.PlugIn.Xml
{
	public class XmlNodeValueSpecification : ISpecification
	{
		private readonly string _nodeName;
		private readonly string _nodeValue;
		private readonly string _fileExtension;

		public XmlNodeValueSpecification(
			string nodeName,
			string nodeValue,
			string fileExtension )
		{
			Contract.Requires<ArgumentException>( nodeName.IsNotEmpty());
			Contract.Requires<ArgumentException>( fileExtension.IsNotEmpty() );
			Contract.Requires<ArgumentException>(nodeValue.IsNotEmpty());
			_nodeName = nodeName;
			_nodeValue = nodeValue;
			_fileExtension = fileExtension;
		}

		public bool IsSatisfiedBy( IFileInfo file )
		{
			if( file.Extension.Replace(".", "").ToLower() != _fileExtension)
				return false;

			var lastElementName = "";
			try {
				using( var xml = XmlReader.Create( file.OpenText() ) ) {
					while( xml.Read() ) {
						switch( xml.NodeType ) {
							case XmlNodeType.Element :
								lastElementName = xml.Name;
								break;
							case XmlNodeType.Text :
								if( lastElementName == _nodeName &&
								    xml.Value == _nodeValue )
									return true;
								break;
						}
					}
				}
			}
			catch( XmlException e ) {
				return false;
			}
			return false;
		}
	}
}