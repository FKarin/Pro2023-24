using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VajeRazredi6
{
    internal class Palčke
    {
        int štPalčk, igralec;
        public Palčke()
        {
            štPalčk = 11;
            igralec = 1;
        }
        public Palčke(int šp)
        {
            štPalčk = šp;
            igralec = 1;
        }
        public Palčke(int šp, int i)
        {
            štPalčk = šp;
            igralec = i;
        }
        public void VzemiPalčke(int n)
        {
            if(n>=1 && n <= 3)
            {
                štPalčk -= n;
                igralec = 3 - igralec;
            }
            else
            {
                Console.WriteLine("Dovoljeno je od 1 do 3 palčke. Vzeti si hotel "+n+".");
            }
        }

        public bool KonecIgre()
        {
            return štPalčk <= 0;
        }
        public int DobiZmagovalca()
        {
            return igralec;
        }
        public void IzpisStanja()
        {
            Console.WriteLine("Na mizi je "+štPalčk+" palčk.");
            Console.WriteLine("Na vrsti je "+igralec+".");
        }
    }
    
}
