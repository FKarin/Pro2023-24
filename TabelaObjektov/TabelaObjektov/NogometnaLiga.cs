using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TabelaObjektov
{
    internal class NogometnaLiga
    {
        Mostvo[] m = new Mostvo[10];
        int x = 0, y = 1;
        int[] gor = { 2, 3, 4, 5 };
        int[] dol = { 9, 8, 7, 6 };
        int[,] pari = new int[10, 10];
        //pari[2,4]=7 pomeni da se epika 2 in 4 srečata v 7. kolu
        public void NapolniPare(int kolo)
        {
            pari[x, y] = kolo;
            for(int i = 0; i < 4; i++)
            {
                pari[gor[i], dol[i]] = kolo;
            }
            //zavrti za naslednje kolo
            int temp = y;//začasno sharnim y
            y = dol[0];
            dol[0] = dol[1];
            dol[1] = dol[2];
            dol[2] = dol[3];
            dol[3] = gor[3];
            gor[3] = gor[2];
            gor[2] = gor[1];
            gor[1] = gor[0];
            gor[0] = temp;
        }

        public void IzdelajTurnir()
        {
            for (int kolo = 1; kolo <= 9; kolo++)
                NapolniPare(kolo);
        }

        public NogometnaLiga()
        {
            m[0] = new Mostvo("Slovenija");
            m[1] = new Mostvo("Italija  ");
            m[2] = new Mostvo("Irska    ");
            m[3] = new Mostvo("Anglija  ");
            m[4] = new Mostvo("Nemčija  ");
            m[5] = new Mostvo("Polska   ");
            m[6] = new Mostvo("Švica    ");
            m[7] = new Mostvo("Švedska  ");
            m[8] = new Mostvo("Češka    ");
            m[9] = new Mostvo("Belgija  ");
            IzdelajTurnir();
        }

        public void IzpisTurnir()
        {
            for(int kolo = 1; kolo <= 9; kolo++)
            {
                Console.WriteLine(kolo+". kolo");
                for(int i = 0; i < 10; i++) { 
                    for(int j = 0; j < 10; j++)
                    {
                        if (pari[i, j] == kolo)
                        {
                            //ekipa i in j se srečata v tem kolu
                            Console.WriteLine(m[i].Ime +" : "+ m[j].Ime);
                        }
                    }
                }
            }
            
        }

        public void VnesiKolo(int kolo)
        {
            //ponovi za vse pare tega kola
            //rač izpiše npr slovenija:italija
            //uporabnik vnese rezultat v obliki 2:3
            //izpiši vse ekipe
            Console.WriteLine(kolo + ". kolo");
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (pari[i, j] == kolo)
                    {
                        Console.WriteLine(m[i].Ime + " : " + m[j].Ime);
                        string r = Console.ReadLine();
                        string[] vsi = r.Split(':');
                        int goli1 = int.Parse(vsi[0]);
                        int goli2 = int.Parse(vsi[1]);
                        m[i].VpisRezultata(goli1, goli2);
                        m[j].VpisRezultata(goli2, goli1);
                    }
                }
            }
            Mostvo[] urejena = new Mostvo[10];
            for (int i = 0; i < 10; i++)
            {
                urejena[i] = m[i];
            }
            for (int i = 0; i < 10; i++)
            {
                Mostvo max = urejena[i];
                int maxindex = i;
                for (int j = i+1; j < 10; j++)
                {
                    if (urejena[i].BoljšeMoštvo(max))
                    {
                        max = urejena[j];
                        maxindex = j;
                    }
                }
                Mostvo temp = urejena[i];
                urejena[i] = urejena[maxindex];
                urejena[maxindex] = temp;
            }
            Console.WriteLine("****** REZULTATI ******");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(urejena[i].Izpis());
            }
            Console.WriteLine("***********************");
        }
        //dodatno
        //sortiraj tabelo liga v smislu BoljšeMoštvo, spet izpiši
    }
}
