using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabelaObjektov
{
    internal class Mostvo
    {
        string ime;
        int štTekem, štZmag, štNedoločenih, daniGoli, prejetiGoli;

        public string Ime { get => ime; set => ime = value; }

        public Mostvo(string i)
        {
            ime = i;
            štTekem = 0; štZmag = 0; štNedoločenih = 0; daniGoli = 0; prejetiGoli = 0;
        }

        public void VpisRezultata(int d, int p)
        {
            //vpiši rezultat za ekipo. d = dani goli, p = prejeti
            daniGoli += d;
            prejetiGoli += p;
            štTekem++;
            if (d > p)
                štZmag++;
            if (d == p)
                štNedoločenih++;
        }

        //koliko ima ekipa točk
        public int ŠtTočk()
        {
            return štZmag * 3 + štNedoločenih;
        }

        public int GolRazlika()
        {
            return daniGoli - prejetiGoli;
        }

        public string Izpis()
        {
            return ime + "\t" + ŠtTočk() + "\t" + GolRazlika() + "\t" + daniGoli;
        }

        public bool BoljšeMoštvo(Mostvo x)
        {
            if (this.ŠtTočk() > x.ŠtTočk())
                return true;
            if (this.ŠtTočk() == x.ŠtTočk() && this.GolRazlika() > x.GolRazlika())
                return true;
            if (this.ŠtTočk() == x.ŠtTočk() &&
                this.GolRazlika() == x.GolRazlika() &&
                this.daniGoli > x.daniGoli)
                return true;
            return false;
        }
    }
}
