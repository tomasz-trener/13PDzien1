using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01Wstep
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string napis = "ala ma kota";
            char znak = 'd';

            int liczby = 5;
            double liczbyNiecalkowite = 5.7;

            string zamianaNaDuze=  napis.ToUpper();
            string zamianaNaMale = napis.ToLower();

            string zamiana=  napis.Replace("ma", "bedzie miala");

            bool czyZawiera= napis.Contains("ma");

            int indeks= napis.IndexOf("ma");

            string usuwanieSpacji = napis.Trim('_','+');

            string n = "kota";
            string laczenie = "ala" + " ma" + n;

            string laczenie2 = "ala" + 4;

            int wiek = 30;
            int wzrost = 166;
            string wynik1 = "ala ma " + wiek + " lat i ma " + wzrost + "cm";

            string wynik2 = string.Format("ala ma {0} lat i ma {1}", wiek, wzrost);
            string wynik3 = $"ala ma {wiek} lat i ma {wzrost}";

            string wynik4 = "ala ma " +
                "kota";

            string wynik5 = @"ala ma
                        kota";

            string wynik6 = "ala\nma\tkota";

            // komentarz jedno-liniowy 
            /* komentarz
             *  wielo
               liniowy
             */

            string sciezka1 = "c:\\dane\\plik.txt";

            string nazwaPliku = null;
            string sciezka2 = $@"c:\dane\{nazwaPliku}.txt";
            // wywolanie podpowiedzi ctrl + .

            string wynik7 = "ala" + Environment.NewLine + "ma" + Environment.NewLine + "kota";

            string podciag1 = napis.Substring(4);
            string podciag2 = napis.Substring(4,2);






        }
    }
}
