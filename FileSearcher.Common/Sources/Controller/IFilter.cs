using FileSearcher.Common.Model.Specifications;

namespace FileSearcher.Common.Controller
{
    public interface IFilter
    {
        ISpecification GetFilteringSpecification();

        bool Enabled { get; set; }
    }
}