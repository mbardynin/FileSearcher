using FileSearcher.Common.Specifications;

namespace FileSearcher.GUI.Filters
{
    public interface IFilter
    {
        ISpecification GetFilteringSpecification();

        bool Enabled { get; set; }
    }
}