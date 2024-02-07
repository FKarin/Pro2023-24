using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VajeRazredi2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Avto a1 = new Avto("KP M3-915",165,6.8);
            a1.IzpišiVse();
            Console.WriteLine("Doseg: " + a1.Doseg());
            Console.WriteLine("Naslednji servis je čez " + a1.NaslednjiServis(15000) + "km.");
            Console.WriteLine();
            Avto a2 = new Avto("LJ A1-123", 200, 7.25, 28.9, 87345);
            a2.IzpišiVse();
            Console.WriteLine("Doseg: "+a2.Doseg());
            Console.WriteLine("Naslednji servis je čez "+a2.NaslednjiServis(15000)+"km.");
        }
    }
}
