using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARGB
{
    public partial class Form1 : Form
    {
        Color ozadje = Color.Wheat;
        Color ospredje = Color.FromArgb(100, 0, 0, 255);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush br = new SolidBrush(ozadje);
            g.FillRectangle(br, 45, 20, 150, 120);
            Brush br1 = new SolidBrush(ospredje);
            g.FillRectangle(br1, 65, 35, 170, 130);
        }

        private void btnOzadje_Click(object sender, EventArgs e)
        {
            ozadje = Color.FromName(txtImeBarve.Text);
            Invalidate();
        }

        private void btnOspredje_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtA.Text);
            int r = int.Parse(txtR.Text);
            int g = int.Parse(txtG.Text);
            int b = int.Parse(txtB.Text);
            if (a >= 0 && a <= 255 && r >= 0 && r <= 255 && g >= 0 && g <= 255 && b >= 0 && b <= 255)
                ospredje = Color.FromArgb(a, r, g, b);
            Invalidate();
        }
    }
}
