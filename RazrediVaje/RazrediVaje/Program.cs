using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazrediVaje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Krog k = new Krog(37, 45, 2.5f);
            Console.WriteLine("X koordinata = " + k.X +
            "\nY koordinata = " + k.Y +
            "\nRadij =" + k.Radij);
            Console.WriteLine("Premer = " + k.Premer());
            Console.WriteLine("Plošcina =" + k.Ploščina());
            k.X = 2;
            k.Y = 2;
            k.Radij = 4.25f;
            Console.WriteLine("Nova pozicija :");
            Console.WriteLine("X koordinata = " + k.X +
            "\nY koordinata = " + k.Y +
            "\nRadij =" + k.Radij);
            Console.WriteLine("Premer = " + k.Premer());
            Console.WriteLine("Plošcina =" + k.Ploščina());
            Console.ReadLine();

            Pravokotnik p = new Pravokotnik(0, 1, 1, 0);
            Console.WriteLine("Koordinati kota levo zgoraj = " + p.X1 + "," + p.Y1 +
            "\nKoordinati kota desno spodaj = " + p.X2 + "," + p.Y2);
            Console.WriteLine("Stranica a " + p.StranicaA());
            Console.WriteLine("Stranica b " + p.StranicaB());
            Console.WriteLine("Plošina " + p.Ploščina());
            Console.ReadLine();

            Valj v = new Valj(37, 45, 2.5f, 1f);
            Console.WriteLine("X koordinata = " + v.X +
            "\nY koordinata = " + v.Y +
            "\nRadij =" + v.Radij +
            "\nVišina =" + v.Višina);
            Console.WriteLine("Površina = " + v.Površina());
            Console.WriteLine("Volumen =" + v.Volumen());
            Console.ReadLine();

            Kvader k1 = new Kvader(5,5,10,10,5f);
            Console.WriteLine("Koordinati kota levo zgoraj = " + k1.X1 + "," + k1.Y1 +
            "\nKoordinati kota desno spodaj = " + k1.X2 + "," + k1.Y2);
            Console.WriteLine("Stranica a " + k1.StranicaA());
            Console.WriteLine("Stranica b " + k1.StranicaB());
            Console.WriteLine("Površina " + k1.Površina());
            Console.WriteLine("Volumen " + k1.Volumen());
        }
    }
}
