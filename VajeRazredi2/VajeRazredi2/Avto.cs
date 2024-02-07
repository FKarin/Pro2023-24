using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VajeRazredi2
{
    internal class Avto
    {
        private string regŠt;
        private double največjaHitrost, povprečnaPoraba, količinaGorivaVRezervoarju;
        private int prevoženiKilometri;
        public string RegŠt { get => regŠt; set => regŠt = value; }
        public double NajvečjaHitrost { get => največjaHitrost; set => največjaHitrost = value; }
        public double PovprečnaPoraba { get => povprečnaPoraba; set => povprečnaPoraba = value; }
        public double KoličinaGorivaVRezervoarju { get => količinaGorivaVRezervoarju; set => količinaGorivaVRezervoarju = value; }
        public int PrevoženiKilometri { get => prevoženiKilometri; set => prevoženiKilometri = value; }

        public Avto(string rš, double nh, double pp)
        {
            regŠt = rš;
            največjaHitrost = nh;
            povprečnaPoraba = pp;
            količinaGorivaVRezervoarju = 0;
            prevoženiKilometri = 0;
        }
        public Avto(string rš, double nh, double pp, double gvr, int pk)
        {
            regŠt = rš;
            največjaHitrost = nh;
            povprečnaPoraba = pp;
            količinaGorivaVRezervoarju = gvr;
            prevoženiKilometri = pk;
        }
        public double Doseg()
        {
            return 100 * KoličinaGorivaVRezervoarju / povprečnaPoraba;
        }
        public void IzpišiVse()
        {
            Console.WriteLine("Registerska št.:                "+regŠt);
            Console.WriteLine("Največja hitrost:               "+največjaHitrost+"km/h");
            Console.WriteLine("Povprečna poraba:               "+povprečnaPoraba);
            Console.WriteLine("Količina goriva v rezevoarju:   "+količinaGorivaVRezervoarju);
            Console.WriteLine("Prevoženi km:                   "+prevoženiKilometri);
        }
        public double NaslednjiServis(int n)
        {
            return n - (prevoženiKilometri % n);
        }
    }
}
