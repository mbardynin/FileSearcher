// Mike Bardynin [mikebardynin@gmail.com]

using System;
using System.IO;

namespace FileSearcher.Core
{
	public interface IFilter
	{
		bool IsPass( FileInfo file );
	}

	internal class BaseFilter : IFilter
	{
		public bool IsPass( FileInfo file )
		{
			throw new NotImplementedException();
		}
	}
}