// Mike Bardynin [mikebardynin@gmail.com]

using System.IO;

using FileSearcher.Common.Controller.Filters;
using FileSearcher.Common.Model.Specifications;
using FileSearcher.GUI.Controls.Sources;
using FileSearcher.GUI.Implementations.Model.Specifications;

namespace FileSearcher.GUI.Implementations.Controller.Filters
{
	internal sealed class AttributeFilter : AbstractControlFilter<CheckboxSearchFilterView>
	{
		private readonly FileAttributes _attributes;

		public AttributeFilter(CheckboxSearchFilterView view, FileAttributes attributes)
			: base( view )
		{
			_attributes = attributes;
			View.Text = attributes.ToString();
		}

		protected override ISpecification DoGetFilteringSpecification()
		{
			return new AttributeSpecification( _attributes, View.Checked );
		}
	}
}