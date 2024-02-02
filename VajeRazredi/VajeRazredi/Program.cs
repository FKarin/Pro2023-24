using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace VajeRazredi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Točka t1 = new Točka(1.0, 1.0);
            t1.Izpis();
            Točka t2 = new Točka(1.0, 180);
            t2.Izpis();
        }
    }
}
