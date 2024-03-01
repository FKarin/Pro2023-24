using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsVaja
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SpremeniBarvo(object sender, EventArgs e)
        {
            DialogResult a = dlgBarva.ShowDialog();
            if (a == DialogResult.OK)
                textBox1.ForeColor = dlgBarva.Color;
        }
    }
}
