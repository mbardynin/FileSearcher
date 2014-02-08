using System.Collections.Generic;

using FileSearcher.Common.Model.Specifications;

namespace FileSearcher.Common.Model
{
	public interface IFileSearchManager {
		IEnumerable<IFileInfo> Search(
			FileSearchSettings settings,
			ISpecification filter );

		bool ResultIsLimited { get; }
	}
}