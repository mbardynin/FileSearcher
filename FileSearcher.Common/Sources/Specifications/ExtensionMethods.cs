// Mike Bardynin [mikebardynin@gmail.com]
namespace FileSearcher.Common.Specifications
{
	public static class ExtensionMethods
	{
		public static ISpecification And(
			this ISpecification s1,
			ISpecification s2)
		{
			return new AndSpecification(s1, s2);
		} 
	}
}