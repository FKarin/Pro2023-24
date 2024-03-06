using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace StiriVVrsto
{
    public partial class Form1 : Form
    {
        int S_CELICA = 100; //širina enega kvadratka
        int[,] STANJE ={
                        {0,0,0,0,0,0,0},
                        {0,0,0,1,0,0,0},
                        {0,0,1,2,0,0,0},
                        {0,1,2,1,2,0,0},
                        {1,1,2,2,1,2,0}
                        };
        int ST_VRSTIC = 5;
        int ST_STOLPCEV = 7;
        int igralec = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            narišiVodoravne(g);
            narišiNavpične(g);
            narišiKrožce(g);
        }

        public void narišiVodoravne(Graphics g)
        {
            Pen p = new Pen(Color.Black);
            for (int i = 0; i <= ST_VRSTIC; i++)
                g.DrawLine(p, 0, i * S_CELICA, ST_STOLPCEV * S_CELICA, i * S_CELICA);
        }

        public void narišiNavpične(Graphics g)
        {
            Pen p = new Pen(Color.Black);
            for (int i = 0; i <= ST_STOLPCEV; i++)
                g.DrawLine(p, i * S_CELICA, 0, i * S_CELICA, ST_VRSTIC * S_CELICA);
        }

        public void narišiKrožce(Graphics g)
        {
            SolidBrush barva = new SolidBrush(Color.Red);
            //preglej celo tabelo stanje. če je 1 = zelen krog, 2 = rdeč krog
            for(int i = 0; i < ST_VRSTIC; i++)
            {
                for (int j = 0; j < ST_STOLPCEV; j++)
                {
                    if (STANJE[i,j] != 0)
                    {
                        if (STANJE[i, j] == 1)
                            barva = new SolidBrush(Color.Green);
                        else
                            barva = new SolidBrush(Color.Red);
                        g.FillEllipse(barva, j * 100 + 5, i * 100 + 5, 90, 90);
                    }
                }
            }
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            int vrstica = e.Y / 100;
            int stolpec = e.X / 100;
            STANJE[vrstica, stolpec] = igralec;
            igralec = 3 - igralec;
            pictureBox1.Invalidate();
        }
    }
}
