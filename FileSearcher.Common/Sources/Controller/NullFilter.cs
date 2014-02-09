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
		public Control UserControl { get; private set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public string FileExtension { get; set; }
	}
}