using System.Collections.Generic;

using FileSearcher.Common;
using FileSearcher.Common.Specifications;

namespace FileSearcher.Core.Model
{
	public interface IFileSearchManager {
		IEnumerable<IFileInfo> Search(
			FileSearchSettings settings,
			ISpecification filter );

		bool ResultIsLimited { get; }
	}
}