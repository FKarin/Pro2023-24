using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsVaja2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SpremeniBarvo(object sender, EventArgs e)
        {
            DialogResult b = dlgBarva.ShowDialog();
            if (b == DialogResult.OK)
                txtVnos.ForeColor = dlgBarva.Color;
        }

        private void SpremeniFont(object sender, EventArgs e)
        {
            DialogResult f = dlgFont.ShowDialog();
            if (f == DialogResult.OK)
                txtVnos.Font = dlgFont.Font;
        }
    }
}
