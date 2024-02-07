using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulatorV3
{
    internal abstract class Študent
    {
        int delni1, delni2, seminar, ustna;
        public int Delni1 { get => delni1; 
            set
            {
                if (value >= 0 && value <= 100)
                    delni1 = value;
                else
                    throw new Exception("Napačna ocena vpisana.");
            } 
        }
        public int Delni2 { get => delni2; 
            set
            {
                if (value >= 0 && value <= 100)
                    delni2 = value;
                else
                    throw new Exception("Napačna ocena vpisana.");
            }
        }
        public int Seminar { get => seminar; 
            set
            {
                if (value >= 0 && value <= 100)
                    seminar = value;
                else
                    throw new Exception("Napačna ocena vpisana.");
            }
        }
        public int Ustna { get => ustna; 
            set
            {
                if (value >= 0 && value <= 100)
                    ustna = value;
                else
                    throw new Exception("Napačna ocena vpisana.");
            }
        }

        public abstract double KončnaOcena();
        public abstract string Črka();
        public abstract string Izpis();
    }
}
