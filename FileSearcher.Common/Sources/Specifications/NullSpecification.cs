namespace FileSearcher.Common.Specifications
{
	public class NullSpecification : ISpecification {
		public bool IsSatisfiedBy( IFileInfo file )
		{
			return true;
		}
	}
}