using FileSearcher.Common.Model.Specifications;

namespace FileSearcher.Common.Controller
{
    public abstract class AbstractFilter : IFilter
    {
        public ISpecification GetFilteringSpecification()
        {
            return !Enabled
                       ? new NullSpecification()	
                       : DoGetFilteringSpecification();
        }

        protected abstract ISpecification DoGetFilteringSpecification();

        private bool _isEnabled = true;
        public virtual bool Enabled { get { return _isEnabled = true; } set { _isEnabled = value; } }
    }
}