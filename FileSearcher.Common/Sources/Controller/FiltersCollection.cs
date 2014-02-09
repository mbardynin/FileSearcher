using System.Collections.Generic;
using System.Linq;

using FileSearcher.Common.Model.Specifications;

namespace FileSearcher.Common.Controller
{
    public class FiltersCollection : AbstractFilter
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
                  filter ) => resultSpecification.And( filter.GetSpecification() ) );
        }
    }
}