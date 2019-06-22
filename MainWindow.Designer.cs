namespace color_picker
{
    partial class MainWindow
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
			this.panelColorPicker = new System.Windows.Forms.Panel();
			this.SuspendLayout();

			// panelColorPicker
			this.panelColorPicker.BackColor = System.Drawing.Color.White;
			this.panelColorPicker.Location = new System.Drawing.Point(12, 12);
			this.panelColorPicker.Name = "panelColorPicker";
			this.panelColorPicker.Size = new System.Drawing.Size(180, 240);
			this.panelColorPicker.TabIndex = 0;
			this.panelColorPicker.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);

			// MainWindow
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(347, 269);
			this.Controls.Add(this.panelColorPicker);
			this.Name = "MainWindow";
			this.Text = "Form1";
			this.ResumeLayout(false);
        }

		private System.Windows.Forms.Panel panelColorPicker;
	}
}
