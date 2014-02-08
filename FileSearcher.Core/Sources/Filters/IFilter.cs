using System;

using FileSearcher.Common.Specifications;

namespace FileSearcher.Core.Filters
{
    public interface IFilter
    {
        ISpecification GetFilteringSpecification();

        bool Enabled { get; set; }
    }
}