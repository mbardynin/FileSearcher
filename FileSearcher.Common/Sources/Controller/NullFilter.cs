using FileSearcher.Common.Model.Specifications;

namespace FileSearcher.Common.Controller
{
	public class NullFilter : IFilter {
		public ISpecification GetFilteringSpecification()
		{
			return new NullSpecification();
		}

		public bool Enabled { get; set; }
	}
}