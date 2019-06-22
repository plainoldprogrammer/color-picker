using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace color_picker
{
	static class Program
	{
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			MainWindow mainWindow = new MainWindow();
			mainWindow.Text = "Color Picker";
			Application.Run(mainWindow);
		}
	}
}
