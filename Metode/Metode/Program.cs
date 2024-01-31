using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kateri je tvoj najljubši jezik?");
            string x = Console.ReadLine();
            Console.WriteLine("Koliko ga imaš rad?");
            string y = Console.ReadLine();
            IzpišiSporočilo(x, y);
            IzpišiSporočilo(x);
            IzpišiSporočilo(42);

            //int a = IzpišiSporočilo();
            //Console.WriteLine("Metoda je vrnila " + a);

            //Console.WriteLine("Drugi klic "+IzpišiSporočilo());
        }
        static void IzpišiSporočilo(string jezik, string koliko)
        {
            Console.WriteLine("Rada imam " + jezik + " " + koliko + "!");
        }

        static void IzpišiSporočilo(string jezik)
        {
            Console.WriteLine("Rada imam " + jezik + "!");
        }
        static void IzpišiSporočilo(int število)
        {
            Console.WriteLine("More najljubše število je " + število);
        }
    }
}