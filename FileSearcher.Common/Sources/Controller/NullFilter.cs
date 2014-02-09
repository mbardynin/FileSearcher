using System.Windows.Forms;

using FileSearcher.Common.Model.Specifications;

namespace FileSearcher.Common.Controller
{
	public class NullFilter : IPluginFilter {
		public ISpecification GetFilteringSpecification()
		{
			return new NullSpecification();
		}

		public bool Enabled { get; set; }
		public Control View { get; private set; }
	}
}