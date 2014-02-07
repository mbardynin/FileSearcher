// Mike Bardynin [mikebardynin@gmail.com]

using System;
using System.Collections;

using FileSearcher.Common;
using FileSearcher.Core.Filtering;

using Moq;

using NUnit.Framework;

namespace FileSearcher.Core.Tests
{
	[ TestFixture ]
	public class DateTimeFilterTests
	{
		[ TestCaseSource( "TestCases" ) ]
		public bool Test(
			DateTime? minDate,
			DateTime? maxDate,
			IFileInfo fileInfo )
		{
			return new DateTimeFilter( minDate, maxDate, d => d.CreationTime ).IsPass( fileInfo );
		}

		public static IEnumerable TestCases
		{
			get
			{
				var now = DateTime.Now;
				yield return
					new TestCaseData( null, now, GetFileInfo( DateTime.MinValue ) ).Returns( true ).SetName( "MinDate is null." );
				yield return
					new TestCaseData( now, null, GetFileInfo( DateTime.MaxValue ) ).Returns( true ).SetName( "MaxDate is null." );
				yield return
					new TestCaseData( DateTime.MaxValue, DateTime.MinValue, GetFileInfo( now ) ).Throws( typeof( ArgumentException ) )
						.SetName( "MaxDate is less than MinDate." );

				yield return
					new TestCaseData( now, NowAddHours( 2 ), GetFileInfo( NowAddHours( 1 ) ) ).Returns( true )
						.SetName( "Date between bounds." );
				yield return new TestCaseData( now, now, GetFileInfo( now ) ).Returns( true ).SetName( "Date on bounds." );
				yield return
					new TestCaseData( now, NowAddHours( 2 ), GetFileInfo( NowAddHours( 5 ) ) ).Returns( false )
						.SetName( "Date greater bounds." );
				yield return
					new TestCaseData( now, NowAddHours( 2 ), GetFileInfo( NowAddHours( -2 ) ) ).Returns( false )
						.SetName( "Date less bounds." );
				yield return
					new TestCaseData( now, now, null ).Throws( typeof( ArgumentNullException ) ).SetName( "FileInfo is null." );
			}
		}

		private static IFileInfo GetFileInfo( DateTime date )
		{
			var fileInfoMock = new Mock<IFileInfo>();
			fileInfoMock.SetupGet( x => x.CreationTime ).Returns( date );
			return fileInfoMock.Object;
		}

		private static DateTime NowAddHours( int hours )
		{
			return DateTime.Now + TimeSpan.FromHours( hours );
		}
	}
}