using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpressPrint
{
    public partial class Form1 : Form
    {
        Bitmap original = new Bitmap(640, 400);
        public Form1()
        {
            InitializeComponent();
        }

        private void izhodToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void odpriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dlgOdpri.Filter = "Slike(*.jpg, *.png, *.bmp)|*.jpg;*.png;*.bmp";
            DialogResult a = dlgOdpri.ShowDialog();
            if (a != DialogResult.OK)
                return;
            string imeDatoteke = dlgOdpri.FileName;
            original = new Bitmap(imeDatoteke);
            pictureBox1.Image = original;
            PosodobiSliko();
        }

        private void NastaviDrsnike()
        {
            if(original.Width < pictureBox1.Width)
                hScrollBar1.Visible = false;
            else
            {
                hScrollBar1.Visible = true;
                hScrollBar1.Maximum = original.Width - pictureBox1.Width;
            }
            if (original.Height < pictureBox1.Height)
                vScrollBar1.Visible = false;
            else
            {
                vScrollBar1.Visible = true;
                vScrollBar1.Maximum = original.Height - pictureBox1.Height;
            }
        }

        private void PosodobiSliko()
        {
            NastaviDrsnike();
            Graphics g = pictureBox1.CreateGraphics();
            Rectangle r1 = new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height);
            Rectangle r2 = new Rectangle(hScrollBar1.Value, vScrollBar1.Value, pictureBox1.Width, pictureBox1.Height);
            g.DrawImage(original, r1, r2, GraphicsUnit.Pixel);
            pictureBox1.Update();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            PosodobiSliko();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            PosodobiSliko();
        }

        private void navpičnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Color pixel;
            for(int x = 0; x < original.Width / 2; x++)
            {
                for(int y = 0; y < original.Height; y++)
                {
                    pixel = original.GetPixel(x, y);
                    original.SetPixel(original.Width - x - 1, y, pixel);
                }
                PosodobiSliko();
            }
        }

        private void negativToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < original.Width / 2; x++)
            {
                for (int y = 0; y < original.Height; y++)
                {
                    Color barva = original.GetPixel(x, y);
                    int r = 255 - barva.R;
                    int g = 255 - barva.G;
                    int b = 255 - barva.B;
                    barva = Color.FromArgb(r, g, b);
                    original.SetPixel(x, y, barva);
                }
                PosodobiSliko();
            }
        }

        private void za90ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            original.RotateFlip(RotateFlipType.Rotate90FlipNone);
            PosodobiSliko();
        }

        private void za180ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            original.RotateFlip(RotateFlipType.Rotate180FlipNone);
            PosodobiSliko();
        }

        private void za270ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            original.RotateFlip(RotateFlipType.Rotate270FlipNone);
            PosodobiSliko();
        }

        private void vodoravnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Color pixel;
            for (int x = 0; x < original.Width; x++)
            {
                for (int y = 0; y < original.Height / 2; y++)
                {
                    pixel = original.GetPixel(x, y);
                    original.SetPixel(x, original.Height - y - 1, pixel);
                }
                PosodobiSliko();
            }
        }

        private void posvetliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Color pixel;
            int r, g, b;
            for (int y = 0; y < original.Height; y++)
            {
                for (int x = 0; x < original.Width; x++) //po širini
                {
                    pixel = original.GetPixel(x, y); //barva pixla
                    r = (int)((double)pixel.R * 0.9); //posvetli rdečo
                    if (r < 0) r = 0;
                    if (r > 255) r = 255;
                    g = (int)((double)pixel.G * 0.9);//posvetli zelo
                    if (g < 0) g = 0;
                    if (g > 255) g = 255;
                    b = (int)((double)pixel.B * 0.9);//posvetli modro
                    if (b < 0) b = 0;
                    if (b > 255) b = 255;
                    original.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
                PosodobiSliko();
            } // Po vsej višini slike
        }

        private void potemniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Color pixel;
            int r, g, b;
            for (int y = 0; y < original.Height; y++)
            {
                for (int x = 0; x < original.Width; x++) //po širini
                {
                    pixel = original.GetPixel(x, y); //barva pixla
                    r = (int)((double)pixel.R * 1.1); //posvetli rdečo
                    if (r < 0) r = 0;
                    if (r > 255) r = 255;
                    g = (int)((double)pixel.G * 1.1);//posvetli zelo
                    if (g < 0) g = 0;
                    if (g > 255) g = 255;
                    b = (int)((double)pixel.B * 1.1);//posvetli modro
                    if (b < 0) b = 0;
                    if (b > 255) b = 255;
                    original.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
                PosodobiSliko();
            } // Po vsej višini slike
        }
    }
}
