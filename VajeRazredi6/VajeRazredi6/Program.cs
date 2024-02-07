using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VajeRazredi6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Palčke p = new Palčke();
            while (!p.KonecIgre())
            {
                p.IzpisStanja();
                Console.WriteLine("Koliko palčk vzameš?");
                int št = int.Parse(Console.ReadLine());
                p.VzemiPalčke(št);
                Console.WriteLine();
            }
            Console.WriteLine("Zmagal je "+p.DobiZmagovalca());
        }
    }
}
