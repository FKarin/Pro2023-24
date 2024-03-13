using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koncerti
{
    enum PrivilegeLevel { Standard, Premium, Executive, PremiumExecutive }
    internal class NakupKarte
    {
        private string imeDogodka, štKupca;
        private PrivilegeLevel nivo;
        private int štVstopnic;

        public bool PreveriŠtVstopnic(PrivilegeLevel p, int št)
        {
            bool vrni = false;
            switch (p)
            {
                case PrivilegeLevel.Standard:
                    vrni = št <= 2;
                    break;
                case PrivilegeLevel.Premium:
                    vrni = št <= 4;
                    break;
                case PrivilegeLevel.Executive:
                    vrni = št <= 8;
                    break;
                case PrivilegeLevel.PremiumExecutive:
                    vrni = št <= 10;
                    break;
            }
            return vrni;
        }
        public string ImeDogodka
        { 
            get => imeDogodka; 
            set 
            {
                if (String.IsNullOrWhiteSpace(value))
                    throw new Exception("Obvezen podatek");
                imeDogodka = value; 
            } 
        }
        public string ŠtKupca 
        { 
            get => štKupca; 
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                    throw new Exception("Obvezen podatek");
                štKupca = value;
            }
        }
        public int ŠtVstopnic
        {
            get => štVstopnic;
            set 
            {
                if (!PreveriŠtVstopnic(nivo, value))
                    throw new Exception("Napačno število za ta status.");
                štVstopnic = value;
            }
        }

        public PrivilegeLevel Nivo
        {
            get => nivo;
            set
            {
                if (!PreveriŠtVstopnic(value, štVstopnic))
                    throw new Exception("Napačno število za ta status.");
                nivo = value;
            }
        }

    }
}
