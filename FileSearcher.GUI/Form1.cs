﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FileSearcher.Common;

namespace FileSearcher.GUI
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			LoadPlugins();

			lbxPlugIns.DisplayMember = "PluginName";
			lbxPlugIns.DataSource = plugInControls;
		}

		private CompositionContainer container;
			DirectoryCatalog catalog;
		private void LoadPlugins()
		{
			catalog = new DirectoryCatalog(".");
			container = new CompositionContainer(catalog);
			container.ComposeParts(this);
		}

		[ImportMany(typeof(SearchControl), AllowRecomposition = true)]
		private IEnumerable<SearchControl> plugInControls = new List<SearchControl>();

		private void btnSetPlugin_Click(object sender, EventArgs e)
		{
			panelForPlugin.Controls.Clear();
			this.panelForPlugin.Controls.Add(lbxPlugIns.SelectedItem as SearchControl);
		}

		private void txtGetText1_Click(object sender, EventArgs e)
		{
			lblResult.Text = ( panelForPlugin.Controls[ 0 ] as SearchControl ).Text1;
		}

		private void btnUpdatePluginsList_Click(object sender, EventArgs e)
		{
			catalog.Refresh();
			lbxPlugIns.DataSource = plugInControls;
		}
	}


}