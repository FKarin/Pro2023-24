using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KraljestvoŽivali
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mačka m = new Mačka();
            m.Izpis();
            m.Oglašanje();
            Console.WriteLine();
            Pes p = new Pes();
            p.Izpis();
            p.Oglašanje();
        }
    }
}
