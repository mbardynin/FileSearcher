﻿using System.Collections.Generic;
using System.Windows.Forms;

using FileSearcher.Common.Controller;

namespace FileSearcher.GUI.View
{
	public interface ISelectPluginView
	{
		void SetPluginsList( IEnumerable<IPluginFilter> plugins );
		DialogResult ShowDialog();
		IPluginFilter SelectedPlugin { get; }
	}
}