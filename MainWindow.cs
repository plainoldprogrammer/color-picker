using System;
using System.Drawing;
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

        private void textBoxRedValue_TextChanged(object sender, EventArgs e)
        {
            Color customColor = Color.FromArgb(Int32.Parse(textBoxRedValue.Text), 0, 0);
            System.Drawing.SolidBrush brush = new System.Drawing.SolidBrush(customColor);
            System.Drawing.Graphics panelGraphics = panelColorPicker.CreateGraphics();

            panelGraphics.FillRectangle(brush, new Rectangle(0, 0, 180, 80));
        }

        private void textBoxGreenValue_TextChanged(object sender, EventArgs e)
        {
            Color customColor = Color.FromArgb(0, Int32.Parse(textBoxGreenValue.Text), 0);
            System.Drawing.SolidBrush brush = new System.Drawing.SolidBrush(customColor);
            System.Drawing.Graphics panelGraphics = panelColorPicker.CreateGraphics();

            panelGraphics.FillRectangle(brush, new Rectangle(0, 80, 180, 80));
        }

        private void textBoxBlueValue_TextChanged(object sender, EventArgs e)
        {
            Color customColor = Color.FromArgb(0, 0, Int32.Parse(textBoxBlueValue.Text));
            System.Drawing.SolidBrush brush = new System.Drawing.SolidBrush(customColor);
            System.Drawing.Graphics panelGraphics = panelColorPicker.CreateGraphics();

            panelGraphics.FillRectangle(brush, new Rectangle(0, 160, 180, 80));
        }
    }
}
