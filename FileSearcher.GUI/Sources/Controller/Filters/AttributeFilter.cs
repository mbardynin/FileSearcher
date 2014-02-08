// Mike Bardynin [mikebardynin@gmail.com]

using System.IO;

using FileSearcher.Common.Controller;
using FileSearcher.Common.Model.Specifications;
using FileSearcher.GUI.Controls.Sources;
using FileSearcher.GUI.Model.Specifications;

namespace FileSearcher.GUI.Controller.Filters
{
	internal sealed class AttributeFilter : AbstractControlFilter
	{
		private readonly CheckboxSearchFilterView _view;
		private readonly FileAttributes _attributes;

		public AttributeFilter(CheckboxSearchFilterView view, FileAttributes attributes)
			: base( view )
		{
			_view = view;
			_attributes = attributes;

			_view.Text = attributes.ToString();
		}

		protected override ISpecification DoGetFilteringSpecification()
		{
			return new AttributeSpecification( _attributes, _view.Checked );
		}
	}
}