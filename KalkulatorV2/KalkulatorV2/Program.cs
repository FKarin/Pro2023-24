using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KalkulatorV2
{
    enum Oddelek { Angleščina = 1, Matematika = 2, Naravoslovje = 3 }
    internal class Program
    {
        static void Main(string[] args)
        {
            //vnesi oddelek
            Console.WriteLine("Vnesi oddelek študenta:");
            int x = int.Parse(Console.ReadLine());
            Oddelek odd = (Oddelek)x;
            int delni1 = 0, delni2 = 0, seminarska = 0, ustna = 0;
            double končnaOcena = 0;
            string končnaČrka = "";
            switch (odd)
            {
                case Oddelek.Angleščina:
                    Console.WriteLine("Vnesi oceno vmesnega izpita:");
                    delni1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Vnesi oceno končnega izpita:");
                    delni2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Vnesi oceno seminarske naloge:");
                    seminarska = int.Parse(Console.ReadLine());
                    Console.WriteLine("Vnesi oceno ustnega izpita:");
                    ustna = int.Parse(Console.ReadLine());
                    končnaOcena = delni1 * 0.25 + delni2 * 0.25 + seminarska * 0.3 + ustna * 0.2;
                    if (končnaOcena >= 93)
                        končnaČrka = "A";
                    else if (končnaOcena >= 85)
                        končnaČrka = "B";
                    else if (končnaOcena >= 78)
                        končnaČrka = "C";
                    else if (končnaOcena >= 70)
                        končnaČrka = "D";
                    else
                        končnaČrka = "F";
                    MessageBox.Show(
                        "****** ŠTUDENT/KA ANGLEŠČINE ******\n" +
                        "Vmesni izpit: " + delni1 + "\n" +
                        "Končni izpit: " + delni2 + "\n" +
                        "Seminarska naloga: " + seminarska + "\n" +
                        "Ustni izpit: " + ustna + "\n" +
                        "Končna ocena: " + končnaOcena + "\n" +
                        "Ocena: " + končnaČrka,
                        "Kalkulator VSŠ",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                        );
                    break;
                case Oddelek.Matematika:
                    Console.WriteLine("Vnesi oceno delnega izpita 1:");
                    delni1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Vnesi oceno delnega izpita 2:");
                    delni2 = int.Parse(Console.ReadLine());
                    končnaOcena = 0.5 * delni1 + 0.5 * delni2;
                    if (končnaOcena >= 90)
                        končnaČrka = "A";
                    else if (končnaOcena >= 83)
                        končnaČrka = "B";
                    else if (končnaOcena >= 76)
                        končnaČrka = "C";
                    else if (končnaOcena >= 65)
                        končnaČrka = "D";
                    else
                        končnaČrka = "F";
                    MessageBox.Show(
                        "****** ŠTUDENT/KA MATEMATIKE ******\n" +
                        "Delni 1: " + delni1 + "\n" +
                        "Delni 2: " + delni2 + "\n" +
                        "Končna ocena: " + končnaOcena + "\n" +
                        "Ocena: " + končnaČrka,
                        "Kalkulator VSŠ",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                        );
                    break;
                case Oddelek.Naravoslovje:
                    Console.WriteLine("Vnesi oceno vmesnega izpita:");
                    delni1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Vnesi oceno končnega izpita:");
                    delni2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Vnesi oceno seminarske naloge:");
                    seminarska = int.Parse(Console.ReadLine());
                    končnaOcena = delni1 * 0.4 + delni2 * 0.4 + seminarska * 0.2;
                    if (končnaOcena >= 90)
                        končnaČrka = "A";
                    else if (končnaOcena >= 80)
                        končnaČrka = "B";
                    else if (končnaOcena >= 70)
                        končnaČrka = "C";
                    else if (končnaOcena >= 60)
                        končnaČrka = "D";
                    else
                        končnaČrka = "F";
                    MessageBox.Show(
                        "****** ŠTUDENT/KA NARAVOSLOVJA ******\n" +
                        "Vmesni izpit: " + delni1 + "\n" +
                        "Končni izpit: " + delni2 + "\n" +
                        "Seminarska naloga: " + seminarska + "\n" +
                        "Končna ocena: " + končnaOcena + "\n" +
                        "Ocena: " + končnaČrka,
                        "Kalkulator VSŠ",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                        );
                    break;
            }
        }
    }
}