using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VajaAbs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DelavecNaUro d1 = new DelavecNaUro();
            d1.DelID = "123";
            d1.Ime = "Janez Novak";
            d1.ŠtUr = 180;
            d1.UrnaPostavka = 9.5;
            d1.Izpis();
            d1.UgotoviUporabnika();
            LetniDelavec d2 = new LetniDelavec("789","Miha Novak",12000);
            d2.Izpis();
            DelavecBazni x;
            x = new DelavecNaUro();
            x = new LetniDelavec("789", "Miha Novak", 12000);
            IVarnost y = new DelavecNaUro();
            y.BeležiDostop();
        }
    }
}
