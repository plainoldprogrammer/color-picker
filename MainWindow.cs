using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace color_picker
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

		private void Panel1_Paint(object sender, PaintEventArgs e)
		{
			System.Drawing.SolidBrush brush = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
			System.Drawing.Graphics panelGraphics;
			panelGraphics = panelColorPicker.CreateGraphics();
	
			panelGraphics.FillRectangle(brush, new Rectangle(0, 0, 180, 80) );
			
			brush.Color = System.Drawing.Color.Green;
			panelGraphics.FillRectangle(brush, new Rectangle(0, 80, 180, 80));
		
			brush.Color = System.Drawing.Color.Blue;
			panelGraphics.FillRectangle(brush, new Rectangle(0, 160, 180, 80));

			brush.Dispose();
			panelGraphics.Dispose();
		}
	}
}
