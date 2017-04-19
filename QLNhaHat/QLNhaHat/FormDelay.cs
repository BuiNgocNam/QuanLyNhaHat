using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace QLNhaHat
{
    public partial class FormDelay : Form
    {
        Random rand = new Random();
        public FormDelay()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
            Font f = new Font("Matura MT Script Capitals", 30, FontStyle.Bold);
            string text = "Theater Management\nApplication";
            StringFormat format = new StringFormat();
            format.LineAlignment = StringAlignment.Center;
            format.Alignment = StringAlignment.Center;
            g.DrawString(text, f, Brushes.Yellow, ClientRectangle, format);
            int numstar = 5;
            for (int i = 1; i <= numstar; i++)
            {
                int x = rand.Next(0, ClientRectangle.Width);
                int y = rand.Next(0, ClientRectangle.Height);
                int size = rand.Next(2, 6);
                SolidBrush br = new SolidBrush(Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256)));
                g.FillEllipse(br, new Rectangle(x, y, size, size));
            }
            this.Opacity -= 0.01;
            if (Opacity <= 0)
            {
                timer1.Enabled = false;
                this.Close();
            }
        }
    }
}
