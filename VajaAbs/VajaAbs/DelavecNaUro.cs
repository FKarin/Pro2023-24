using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VajaAbs
{
    internal class DelavecNaUro : DelavecBazni,IVarnost
    {
        double urnaPostavka;
        int štUr;
        public override double BrutoPlača
        {
            get { 
                brutoPlača = urnaPostavka * štUr;
                return brutoPlača;
            }
        }

        public double UrnaPostavka { get => urnaPostavka; set => urnaPostavka = value; }
        public int ŠtUr { get => štUr; set => štUr = value; }

        public void BeležiDostop()
        {
            Console.WriteLine("Beležim dostop...");
        }

        public void Geslo()
        {
            Console.WriteLine("Preverjam geslo...");
        }

        public override void Izpis()
        {
            Console.WriteLine("***************DELAVEC***************");
            Console.WriteLine("ID:            " + delID);
            Console.WriteLine("Ime:           " + ime);
            Console.WriteLine("Urna postavka: " + urnaPostavka);
            Console.WriteLine("Število ur:    " + štUr);
            Console.WriteLine("Bruto plača:   " + BrutoPlača);
            Console.WriteLine("*************************************");
        }

        public void UgotoviUporabnika()
        {
            Console.WriteLine("Ugotavljam uporabnika...");
        }
    }
}
