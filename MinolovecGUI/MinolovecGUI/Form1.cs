using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinolovecGUI
{
    public partial class Form1 : Form
    {
        Button[,] x;
        int n = 10;
        LogikaIgre a = new LogikaIgre(10);
        public Form1()
        {
            InitializeComponent();
            x = new Button[n + 2, n + 2];
        }
        private void Prikaži(object sender, EventArgs e)
        {
            //za vse gumbe se kliče ista metoda
            Button b = sender as Button;
            //v b se nahaja gumb, ki sm ga klilnila
            b.ForeColor = Color.Black;
            if (b.Text == "*")
                MessageBox.Show("Konec igre!");
        }

        private void PonastaviGumbe()
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    //oblikuj gumb x[i,j]
                    x[i, j] = new Button();
                    x[i, j].Size = new Size(30, 30);
                    x[i, j].Location = new Point(i * 30, j * 30);
                    if (a.mine[i, j] == true)
                        x[i, j].Text = "*";
                    else
                        x[i, j].Text = a.rešitev[i, j].ToString();
                    x[i, j].BackColor = Color.White;
                    x[i, j].ForeColor = Color.White;
                    x[i, j].Click += new EventHandler(Prikaži);
                    this.Controls.Add(x[i, j]);
                }
            }
        }

        private void BrišiIzForme()
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    //briši gumb
                    Controls.Remove(x[i, j]);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Težko")
            {
                BrišiIzForme();
                button1.Text = "Lahko";
                n = 20;
                x = new Button[n + 2, n + 2];
                a = new LogikaIgre(n);
                PonastaviGumbe();
            }
            else
            {
                BrišiIzForme();
                button1.Text = "Težko";
                n = 10;
                x = new Button[n + 2, n + 2];
                a = new LogikaIgre(n);
                PonastaviGumbe();
            }
            //težko je 20x20, lahko je 10x10
        }
    }
}
