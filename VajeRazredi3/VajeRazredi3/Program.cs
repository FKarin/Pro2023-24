using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VajeRazredi3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Oseba o1 = new Oseba("Klara", 18);
            Oseba o2 = new Oseba("Mitja", 16);
            Oseba o3 = new Oseba("Klara", 18);
            Oseba o4 = new Oseba("Tine", 20);

            Console.WriteLine(o1.GetAgeInMonths());

            Console.WriteLine(o2.IsAdult());
            Console.WriteLine(o4.IsAdult());

            Console.WriteLine(o1.IsEqual(o3));
            Console.WriteLine(o1.IsEqual(o2));
        }
    }
}
