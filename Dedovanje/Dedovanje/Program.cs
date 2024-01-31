using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dedovanje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Delavec d = new Delavec();
            d.DelID = "123";
            d.Ime = "Janko Novak";
            d.UrnaPostavka = 8;
            d.ŠtUr = 176;
            d.Izpis();

            LDelavec l = new LDelavec();
            l.DelID = "456";
            l.Ime = "Miha Kovač";
            l.LetnaPlača = 1200;
            l.Izpis();
        }
    }
}
