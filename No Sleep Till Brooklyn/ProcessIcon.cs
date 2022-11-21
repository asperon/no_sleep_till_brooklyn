using System;
using System.Diagnostics;
using System.Windows.Forms;
using No_Sleep_Till_Brooklyn.Properties;

namespace No_Sleep_Till_Brooklyn
{
	class ProcessIcon : IDisposable
	{
		NotifyIcon ni;

		public ProcessIcon()
		{
			ni = new NotifyIcon();
		}

		public void Display()
		{
			ni.Icon = Resources.Icon;
			ni.Text = "No Sleep Till Brooklyn";
			ni.Visible = true;
			ni.ContextMenuStrip = new ContextMenus().Create();
		}

		public void Dispose()
		{
			ni.Dispose();
		}
	}
}