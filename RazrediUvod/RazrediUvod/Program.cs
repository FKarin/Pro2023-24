using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazrediUvod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //objekt = izvod razreda
            Napis n = new Napis();
            n.najljubšiProgram = "C#";
            n.Izpiši();
            n.Koliko();

            Napis a = new Napis("Java");
            //a.najljubšiProgram = "Java";
            a.Izpiši();
            a.Koliko();
            n.Koliko();
            //nastavitev statične spremenljivke
            Napis.štIzvodov = 5;
            a.Koliko();
        }
    }
}