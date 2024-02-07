using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VajeRazredi4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pravokotnik p1 = new Pravokotnik(5, 5);
            Console.WriteLine(p1.GetArea());
            Console.WriteLine(p1.GetPerimeter());
            Console.WriteLine(p1.IsSquare());
        }
    }
}
