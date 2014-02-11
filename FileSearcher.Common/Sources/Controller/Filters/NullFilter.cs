using System.Windows.Forms;

using FileSearcher.Common.Model.Specifications;

namespace FileSearcher.Common.Controller.Filters
{
	public class NullFilter : IPluginFilter {
		public ISpecification GetSpecification()
		{
			return new NullSpecification();
		}

		public bool Enabled { get; set; }
		public Control UserControl { get; private set; }
		public string Name { get; private set; }
		public string Description { get; private set; }
		public string FileExtension { get { return "*"; } }
	}
}