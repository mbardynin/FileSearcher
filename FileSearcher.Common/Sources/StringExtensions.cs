// Mike Bardynin [mikebardynin@gmail.com]
namespace FileSearcher.Common
{
	public static class StringExtensions
	{
		public static bool IsNullOrEmpty(this string source)
		{
			return string.IsNullOrEmpty( source );
		}
		public static bool IsNotEmpty(this string source)
		{
			return !string.IsNullOrEmpty( source );
		}
	}
}