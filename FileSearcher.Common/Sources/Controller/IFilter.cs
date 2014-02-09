using System.Windows.Forms;

using FileSearcher.Common.Model.Specifications;

namespace FileSearcher.Common.Controller
{
    public interface IFilter
    {
        ISpecification GetSpecification();

        bool Enabled { get; set; }
    }

	public interface IPluginFilter : IFilter
	{
		Control UserControl { get; }

		string Name { get; }
		string Description { get; }
		string FileExtension { get; }

		string ToString();
	}

}