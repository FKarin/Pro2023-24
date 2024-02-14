using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VajeRazredi7
{
    internal abstract class Vozilo
    {
        private string barva;
        private int povprečnaPoraba;
        private string izvajalec;
        private string model;
        private string letoIzdelave;

        protected string Izvajalec { get => izvajalec; set => izvajalec = value; }
        protected string Model { get => model; set => model = value; }
        protected string LetoIzdelave { get => letoIzdelave; set => letoIzdelave = value; }
        protected string Barva { get => barva; set => barva = value; }
        protected int PovprečnaPoraba { get => povprečnaPoraba; set => povprečnaPoraba = value; }
    }
}
