using System;
using System.Drawing;
using System.Windows.Forms;

namespace color_picker
{
    public partial class MainWindow : Form
    {
		private int redValue = 128;
		private int greenValue = 128;
		private int blueValue = 128;

        public MainWindow()
        {
            InitializeComponent();
			textBoxRedValue.Text = redValue.ToString();
			textBoxGreenValue.Text = greenValue.ToString();
			textBoxBlueValue.Text = blueValue.ToString();
        }

		private void panelColorPicker_Paint(object sender, PaintEventArgs e)
		{
			System.Drawing.Graphics panelGraphics;
			panelGraphics = panelColorPicker.CreateGraphics();
	
			System.Drawing.SolidBrush brush = new System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(redValue, 0, 0));
			panelGraphics.FillRectangle(brush, new Rectangle(0, 0, 180, 80) );

			brush.Color = System.Drawing.Color.FromArgb(0, greenValue, 0);
			panelGraphics.FillRectangle(brush, new Rectangle(0, 80, 180, 80));

			brush.Color = System.Drawing.Color.FromArgb(0, 0, blueValue);
			panelGraphics.FillRectangle(brush, new Rectangle(0, 160, 180, 80));

			brush.Dispose();
			panelGraphics.Dispose();
		}

		private void panelColorResulting_Paint(object sender, PaintEventArgs e)
		{
			changePanelColorResulting();
		}

        private void textBoxRedValue_TextChanged(object sender, EventArgs e)
        {
			if (textBoxRedValue.Text.Length != 0)
			{
				int redValue = Int32.Parse(textBoxRedValue.Text);

				if (textBoxRedValue.Text.Equals(""))
				{
					redValue = 0;
				}
				else
				{
					redValue = Int32.Parse(textBoxRedValue.Text);
				}

				if (redValue >= 0 && redValue <= 255)
				{
					System.Drawing.SolidBrush brush = new System.Drawing.SolidBrush(Color.FromArgb(redValue, 0, 0));
					System.Drawing.Graphics panelGraphics = panelColorPicker.CreateGraphics();
					panelGraphics.FillRectangle(brush, new Rectangle(0, 0, 180, 80));
					changePanelColorResulting();
				}
			}
        }

        private void textBoxGreenValue_TextChanged(object sender, EventArgs e)
        {
			if (textBoxGreenValue.Text.Length != 0)
			{
				int greenValue = Int32.Parse(textBoxGreenValue.Text);

				if (textBoxGreenValue.Text.Equals(""))
				{
					greenValue = 0;
				}
				else
				{
					greenValue = Int32.Parse(textBoxGreenValue.Text);
				}

				if (greenValue >= 0 && greenValue <= 255)
				{
					System.Drawing.SolidBrush brush = new System.Drawing.SolidBrush(Color.FromArgb(0, greenValue, 0));
					System.Drawing.Graphics panelGraphics = panelColorPicker.CreateGraphics();
					panelGraphics.FillRectangle(brush, new Rectangle(0, 80, 180, 80));
					changePanelColorResulting();
				}
			}
        }

        private void textBoxBlueValue_TextChanged(object sender, EventArgs e)
        {
			if (textBoxBlueValue.Text.Length != 0)
			{
				int blueValue = Int32.Parse(textBoxBlueValue.Text);

				if (textBoxBlueValue.Text.Equals(""))
				{
					blueValue = 0;
				}
				else
				{
					blueValue = Int32.Parse(textBoxBlueValue.Text);
				}

				if (blueValue >= 0 && blueValue <= 255)
				{
					System.Drawing.SolidBrush brush = new System.Drawing.SolidBrush(Color.FromArgb(0, 0, blueValue));
					System.Drawing.Graphics panelGraphics = panelColorPicker.CreateGraphics();
					panelGraphics.FillRectangle(brush, new Rectangle(0, 160, 180, 80));
					changePanelColorResulting();
				}
			}
        }

		private void changePanelColorResulting()
		{
			Console.WriteLine("R: " + redValue + "\tG: " + greenValue + "\tB: " + blueValue);
			System.Drawing.Color colorMix = System.Drawing.Color.FromArgb(redValue, greenValue, blueValue);
			System.Drawing.SolidBrush brush = new System.Drawing.SolidBrush(colorMix);

			System.Drawing.Graphics panelGraphics = panelColorResulting.CreateGraphics();
			panelGraphics.FillRectangle(brush, new Rectangle(0, 0, 180, 240));
		}
	}
}

