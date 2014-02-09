// Mike Bardynin [mikebardynin@gmail.com]

using System;
using System.Diagnostics.Contracts;
using System.IO;
using System.Xml;

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
			string nodeName, string nodeValue, string fileExtension)
		{
			Contract.Requires<ArgumentException>(!string.IsNullOrEmpty(nodeName));
			Contract.Requires<ArgumentException>(!string.IsNullOrEmpty(fileExtension));
			Contract.Requires<ArgumentException>(!string.IsNullOrEmpty(nodeValue));
			_nodeName = nodeName;
			_nodeValue = nodeValue;
			_fileExtension = fileExtension;
		}

		public bool IsSatisfiedBy( IFileInfo file )
		{
			int maxFileSize = 100*1024*1024;
			if( file.Length > maxFileSize ||
			    file.Extension.ToLower() != _fileExtension )
				return false;

			var lastElementName = "";
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
			return false;
		}
	}
}