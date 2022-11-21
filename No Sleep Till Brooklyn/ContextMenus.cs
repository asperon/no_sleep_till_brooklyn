using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace No_Sleep_Till_Brooklyn
{
	class ContextMenus
	{
		public ContextMenuStrip Create()
		{
			ContextMenuStrip menu = new ContextMenuStrip();
			ToolStripMenuItem item;

			item = new ToolStripMenuItem();
			item.Text = "Exit";
			item.Click += new System.EventHandler(Exit_Click);
			menu.Items.Add(item);

			return menu;
		}

		void Exit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}