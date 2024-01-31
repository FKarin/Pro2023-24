using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enkapsulacija
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student marija = new Student();
            MessageBox.Show(marija.Izpis());
        }
    }
}