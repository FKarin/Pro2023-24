using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestBezier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void xTrack_Scroll(object sender, EventArgs e)
        {
            xText.Text = xTrack.Value.ToString();
            if (radT1.Checked)
                bKontrolnik1.T1 = new Point(xTrack.Value, bKontrolnik1.T1.Y);
            if (radT2.Checked)
                bKontrolnik1.T2 = new Point(xTrack.Value, bKontrolnik1.T2.Y);
            if (radT3.Checked)
                bKontrolnik1.T3 = new Point(xTrack.Value, bKontrolnik1.T3.Y);
            if (radT4.Checked)
                bKontrolnik1.T4 = new Point(xTrack.Value, bKontrolnik1.T4.Y);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            yText.Text = yTrack.Value.ToString();
            if (radT1.Checked)
                bKontrolnik1.T1 = new Point(bKontrolnik1.T1.X, 200 - yTrack.Value);
            if (radT2.Checked)
                bKontrolnik1.T2 = new Point(bKontrolnik1.T2.X, 200 - yTrack.Value);
            if (radT3.Checked)
                bKontrolnik1.T3 = new Point(bKontrolnik1.T3.X, 200 - yTrack.Value);
            if (radT4.Checked)
                bKontrolnik1.T4 = new Point(bKontrolnik1.T4.X, 200 - yTrack.Value);
        }

        private void radT1_CheckedChanged(object sender, EventArgs e)
        {
            xTrack.Value = bKontrolnik1.T1.X;
            yTrack.Value = bKontrolnik1.T1.Y;
            xText.Text = xTrack.Value.ToString();
            yText.Text = (200 - yTrack.Value).ToString();
        }

        private void radT2_CheckedChanged(object sender, EventArgs e)
        {
            xTrack.Value = bKontrolnik1.T2.X;
            yTrack.Value = bKontrolnik1.T2.Y;
            xText.Text = xTrack.Value.ToString();
            yText.Text = (200 - yTrack.Value).ToString();
        }

        private void radT3_CheckedChanged(object sender, EventArgs e)
        {
            xTrack.Value = bKontrolnik1.T3.X;
            yTrack.Value = bKontrolnik1.T3.Y;
            xText.Text = xTrack.Value.ToString();
            yText.Text = (200 - yTrack.Value).ToString();
        }

        private void radT4_CheckedChanged(object sender, EventArgs e)
        {
            xTrack.Value = bKontrolnik1.T4.X;
            yTrack.Value = bKontrolnik1.T4.Y;
            xText.Text = xTrack.Value.ToString();
            yText.Text = (200 - yTrack.Value).ToString();
        }
    }
}
