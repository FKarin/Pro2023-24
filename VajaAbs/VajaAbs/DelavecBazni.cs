using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VajaAbs
{
    internal abstract class DelavecBazni
    {
        protected string delID;
        protected string ime;
        protected double brutoPlača;
        public DelavecBazni(string d, string i)
        {
            delID = d;
            ime = i;
        }
        public DelavecBazni()
        {

        }

        public abstract double BrutoPlača { get; }
        public string Ime { get => ime; set => ime = value; }
        public string DelID { get => delID; set => delID = value; }
        public abstract void Izpis();
    }
}
