using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enkapsulacija
{
    internal class Student
    {
        public string studentID;
        public string ime;
        public string naslov;
        public int star;
        public double povprečnaOcena;

        public Student()
        {
            studentID = "1234";
            ime = "Marija Novak";
            naslov = "Cankarjeva 7, Nova Gorica";
            star = 20;
            povprečnaOcena = 7.5;
        }
        public string Izpis()
        {
            string zaIzpis = "";
            zaIzpis += "******** ŠTUDENT/KA ********\n";
            zaIzpis += "ID                " + studentID + "\n";
            zaIzpis += "Ime               " + ime + "\n";
            zaIzpis += "Naslov            " + naslov + "\n";
            zaIzpis += "Starost           " + star + "\n";
            zaIzpis += "Povprečna ocena   " + povprečnaOcena;
            return zaIzpis;
        }
    }
}