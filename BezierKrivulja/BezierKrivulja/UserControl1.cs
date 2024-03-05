using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace BezierKrivulja
{
    public partial class bKontrolnik: UserControl
    {
        private Point t1 = new Point(0, 0);
        private Point t2 = new Point(10, 30);
        private Point t3 = new Point(50, 20);
        private Point t4 = new Point(100, 40);
        public bKontrolnik()
        {
            InitializeComponent();
        }

        public Point T1 { get => t1; set { t1 = value; Invalidate(); } }
        public Point T2 { get => t2; set { t2 = value; Invalidate(); } }
        public Point T3 { get => t3; set { t3 = value; Invalidate(); } }
        public Point T4 { get => t4; set { t4 = value; Invalidate(); } }

        private void bKontrolnik_Paint(object sender, PaintEventArgs e)
        {
            Rectangle r = new Rectangle(0,0,this.Width,this.Height);
            LinearGradientBrush lb = new LinearGradientBrush(r, Color.Red, Color.Yellow, LinearGradientMode.BackwardDiagonal);
            Graphics g = e.Graphics;
            g.FillRectangle(lb, r);
            Pen p = new Pen(Color.Blue);
            g.DrawBezier(p, t1, t2, t3, t4);
            g.DrawEllipse(p, t1.X - 1, t1.Y - 1, 3, 3);
            g.DrawEllipse(p, t2.X - 1, t2.Y - 1, 3, 3);
            g.DrawEllipse(p, t3.X - 1, t3.Y - 1, 3, 3);
            g.DrawEllipse(p, t4.X - 1, t4.Y - 1, 3, 3);
        }
    }
}
