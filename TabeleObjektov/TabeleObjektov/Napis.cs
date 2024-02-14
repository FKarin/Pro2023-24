using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabeleObjektov
{
    internal class Napis
    {
        //lastonsti razreda
        public string najljubšiProgram;
        public static int štIzvodov = 0;

        //obnašanje - metode
        public Napis()
        {
            Console.WriteLine("Konstruktor brez parametrov.");
            najljubšiProgram = "neznan";
            štIzvodov++;
        }
        public Napis(string jezik)
        {
            Console.WriteLine("Konstruktor z parametri.");
            najljubšiProgram = jezik;
            štIzvodov++;
        }
        public void Izpiši()
        {
            Console.WriteLine("Rada imam " + najljubšiProgram + "!");
        }
        public void Koliko()
        {
            Console.WriteLine("Število izvodov je " + štIzvodov + ".");
        }
        ~Napis()
        {
            Console.WriteLine("Uničevalec.");
        }
    }
}