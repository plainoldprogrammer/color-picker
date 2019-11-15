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
            this.textBoxRedValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxGreenValue = new System.Windows.Forms.TextBox();
            this.textBoxBlueValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // panelColorPicker
            // 
            this.panelColorPicker.BackColor = System.Drawing.Color.White;
            this.panelColorPicker.Location = new System.Drawing.Point(16, 15);
            this.panelColorPicker.Margin = new System.Windows.Forms.Padding(4);
            this.panelColorPicker.Name = "panelColorPicker";
            this.panelColorPicker.Size = new System.Drawing.Size(240, 295);
            this.panelColorPicker.TabIndex = 0;
            this.panelColorPicker.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // textBoxRedValue
            // 
            this.textBoxRedValue.Location = new System.Drawing.Point(344, 18);
            this.textBoxRedValue.Name = "textBoxRedValue";
            this.textBoxRedValue.Size = new System.Drawing.Size(100, 22);
            this.textBoxRedValue.TabIndex = 1;
            this.textBoxRedValue.TextChanged += new System.EventHandler(this.textBoxRedValue_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(276, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Red:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Green:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(276, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Blue:";
            // 
            // textBoxGreenValue
            // 
            this.textBoxGreenValue.Location = new System.Drawing.Point(344, 49);
            this.textBoxGreenValue.Name = "textBoxGreenValue";
            this.textBoxGreenValue.Size = new System.Drawing.Size(100, 22);
            this.textBoxGreenValue.TabIndex = 5;
            this.textBoxGreenValue.TextChanged += new System.EventHandler(this.textBoxGreenValue_TextChanged);
            // 
            // textBoxBlueValue
            // 
            this.textBoxBlueValue.Location = new System.Drawing.Point(344, 79);
            this.textBoxBlueValue.Name = "textBoxBlueValue";
            this.textBoxBlueValue.Size = new System.Drawing.Size(100, 22);
            this.textBoxBlueValue.TabIndex = 6;
            this.textBoxBlueValue.TextChanged += new System.EventHandler(this.textBoxBlueValue_TextChanged);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 326);
            this.Controls.Add(this.textBoxBlueValue);
            this.Controls.Add(this.textBoxGreenValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxRedValue);
            this.Controls.Add(this.panelColorPicker);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

		private System.Windows.Forms.Panel panelColorPicker;
        private System.Windows.Forms.TextBox textBoxRedValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxGreenValue;
        private System.Windows.Forms.TextBox textBoxBlueValue;
    }
}
