using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Grafika1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pero = new Pen(Color.Black);
            pero.Width = 3;
            //pero.EndCap = LineCap.ArrowAnchor;
            //pero.DashStyle = DashStyle.DashDot;
            Point p1 = new Point(100, 100);
            Point p2 = new Point(200, 200);
            //g.DrawLine(pero, p1, p2);
            //g.DrawLine(pero, 100, 100, 200, 200);
            //g.DrawRectangle(pero, 210, 210, 100, 100);
            //g.DrawEllipse(pero, 320, 210, 100, 100);
            Brush b1 = new SolidBrush(Color.Red);
            Rectangle r = new Rectangle(100, 100, 200, 200);
            Brush b2 = new LinearGradientBrush(r, Color.Red, Color.Yellow, 45, false);
            g.FillRectangle(b2, 100, 100, 200, 200);
            g.FillEllipse(b1, 320, 210, 100, 100);
        }
    }
}
