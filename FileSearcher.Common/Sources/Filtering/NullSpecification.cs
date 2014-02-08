namespace FileSearcher.Common.Filtering
{
	class NullSpecification : ISpecification {
		public bool IsSatisfiedBy( IFileInfo file )
		{
			return true;
		}
	}
}