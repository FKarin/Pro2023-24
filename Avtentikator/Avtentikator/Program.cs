using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avtentikator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Avtentikator Simon = new Avtentikator();
            bool narejeno; // narejeno je spremenljivka tipa bool
            narejeno = Simon.SpremeniGeslo("", "UganiGeslo");
            if (narejeno == true)
                Console.WriteLine("Geslo za Simona je spremenjeno");
            else
                Console.WriteLine("Sprememba gesla ni uspela");
            narejeno = Simon.SpremeniGeslo("", "DrugoGeslo");
            if (narejeno == true)
                Console.WriteLine("Geslo za Simona je spremenjeno");
            else
                Console.WriteLine("Sprememba gesla ni uspela");
            if (Simon.JeGesloPravilno("UganiGeslo") == true)
                Console.WriteLine("Geslo za Simona je preverjeno");
            else
                Console.WriteLine("Geslo za Simona ni pravilno");

            Avtentikator Simon2 = new Avtentikator("U2");
            bool narejeno2; // narejeno je spremenljivka tipa bool
            narejeno2 = Simon2.SpremeniGeslo("U2", "DrugoGeslo");
            if (narejeno2 == true)
                Console.WriteLine("Geslo za Simona je spremenjeno");
            else
                Console.WriteLine("Sprememba gesla ni uspela");
            if (Simon2.JeGesloPravilno("UganiGeslo") == true)
                Console.WriteLine("Geslo za Simona je preverjeno");
            else
                Console.WriteLine("Geslo za Simona ni pravilno");

            Avtentikator Simon3 = new Avtentikator();
            bool narejeno3; // narejeno je spremenljivka tipa bool
            string geslo;
            Console.WriteLine("Vnesi geslo");
            geslo = Console.ReadLine();
            narejeno3 = Simon3.SpremeniGeslo("", geslo);
            if (narejeno3 == true)
                Console.WriteLine("Geslo za Simona je spremenjeno");
            else
                Console.WriteLine("Sprememba gesla ni uspela");
        }
    }
}
