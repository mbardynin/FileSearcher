namespace FileSearcher.Common.Model.Specifications
{
	public class NullSpecification : ISpecification {
		public bool IsSatisfiedBy( IFileInfo file )
		{
			return true;
		}
	}
}