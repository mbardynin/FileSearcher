using System.Collections.Generic;
using System.Linq;

using FileSearcher.Common.Specifications;

namespace FileSearcher.Core.Filters.Abstract
{
    public abstract class AbstractListFilter : AbstractFilter
    {
        protected List<IFilter> Helpers = new List<IFilter>();

        public void AddHelper( IFilter helper )
        {
            Helpers.Add( helper );
        }

        protected override ISpecification DoGetFilteringSpecification()
        {
            if( Helpers == null ||
                !Helpers.Any() )
                return new NullSpecification();

            return Helpers.Aggregate(
				new NullSpecification() as ISpecification,
                ( resultSpecification,
                  filter ) => resultSpecification.And( filter.GetFilteringSpecification() ) );
        }
    }
}