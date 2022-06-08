using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P09ProgramowanieObiektoweWstep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "a";
            int b = 5;

            
            StringBuilder sb = new StringBuilder();
            DateTime dt = new DateTime();

            DateTime dt2 = new DateTime(2022, 12, 24);

            Kalkulator k = new Kalkulator();
            Kalkulator.LiczbaDostepnychCyfr = 5;
            //k.LiczbaDostepnychCyfr = 4;
            object o = new object();

            k.Kolor = "czerwony";
            Console.WriteLine(k.Kolor);

            string[] tablica = new string[3];
            try
            {
                tablica[3] = "a";
            }
            catch (Exception)
            {
                tablica[tablica.Length - 1] = "a";

                Console.WriteLine("Podales zbyt duzy indeks");
            }


            Console.WriteLine(tablica[2]);

            Console.WriteLine(k.Szerokosc);

            Kalkulator k2 = new Kalkulator();
            //k2.LiczbaDostepnychCyfr = 7;

            try
            {
                 k.Podziel(4, 0);
            }
            catch (Exception ex)
            {
                Console.WriteLine("wysapil wyjatek");
            }
           


            k.Przemnoz(3, 4);
        }
    }
}
