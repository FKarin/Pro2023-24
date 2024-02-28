using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Liki
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int stranica = int.Parse(txtStranica.Text);
            int ploščina = stranica * stranica;
            int obseg = stranica * 4;
            txtObsegKvadrat.Text = obseg.ToString();
            txtPloščinaKvadrat.Text = ploščina.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int r = int.Parse(txtStranica.Text);
            double ploščina = Math.PI * Math.Pow(r, 2);
            double obseg = 2 * Math.PI * r;
            txtObsegKrog.Text = obseg.ToString();
            txtPloščinaKrog.Text = ploščina.ToString();
        }
    }
}
