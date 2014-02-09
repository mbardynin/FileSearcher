// Mike Bardynin [mikebardynin@gmail.com]

using System.Windows.Forms;

using FileSearcher.Common.Controller;
using FileSearcher.Common.Model.Specifications;

namespace FileSearcher.PlugIn.Txt
{
	internal sealed class TxtSubstringSearchFilter : AbstractControlFilter, IPluginFilter
	{
		private readonly TxtSubstringSearchFilterView _view;

		public TxtSubstringSearchFilter(TxtSubstringSearchFilterView view)
			: base( view )
		{
			_view = view;
		}

		protected override ISpecification DoGetFilteringSpecification()
		{
			return new SubstringSpecification( _view.Substring, FileExtension );
		}

		public Control UserControl { get; private set; }
		public string Name { get { return "Substring search"; } }
		public string Description { get { return "Plug-in for search *.txt files with specific substring."; } }
		public string FileExtension { get { return "txt"; } }

		public override string ToString()
		{
			return string.Format("[{1}] {0}", Name, FileExtension);
		}
	}
}