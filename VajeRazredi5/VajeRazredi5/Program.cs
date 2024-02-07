using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VajeRazredi5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Banka b1 = new Banka(50, 5, 2);
            Console.WriteLine(b1.LetniObračun());
            Console.WriteLine(b1.DnevniObračun());
        }
    }
}
