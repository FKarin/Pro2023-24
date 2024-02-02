using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ruleta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vnesi denarni vložek:");
            int stanje = int.Parse(Console.ReadLine());
            Console.WriteLine("Vnesi začetno višino stavke:");
            int stava = int.Parse(Console.ReadLine());
            int začStanje = stanje;
            int začStava = stava;
            int min = stanje, max = stanje;
            string barva;
            Random r = new Random();
            int i = 0;
            for (i = 0; i < 100; i++)
            {
                int kroglica = r.Next(0, 36);
                if(kroglica % 2 == 0 & kroglica != 0)
                {
                    stanje += stava;
                    stava = začStava;
                    barva = "rdeča";
                }
                else
                {
                    stanje -= stava;
                    stava = 2 * stava;
                    barva = "črna";
                }
                Console.WriteLine("Število meta: "+kroglica);
                Console.WriteLine("Barva: " + barva);
                Console.WriteLine("Stanje: " + stanje);
                Console.WriteLine();
                if (stanje < min)
                    min = stanje;
                if (stanje > max)
                    max = stanje;
            }
            Console.WriteLine("Število metov: "+i);
            Console.WriteLine("Začetno stanje: "+začStanje);
            Console.WriteLine("Končno stanje: "+stanje);
            Console.WriteLine("Začetna stava: "+ začStava);
            Console.WriteLine("Končna stava: "+stava);
            Console.WriteLine("Dobiček/izguba: "+(stanje-začStanje));
        }
    }
}
