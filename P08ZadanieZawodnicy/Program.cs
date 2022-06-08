using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P08ZadanieZawodnicy
{
    internal class Program
    {
        static void Main(string[] args)
        {
          //  string zawartosc = File.ReadAllText(@"c:\dane\zawodnicy.txt");

            WebClient wc = new WebClient();

            string url = "http://tomaszles.pl/wp-content/uploads/2019/06/zawodnicy.txt";
            string dane= wc.DownloadString(url);

            // char a = '\n';

            // string s = "ala\nma\nkota";
            // int dlugosc =s.Length;
            //Console.WriteLine(dane);

            //string[,] tabDwuWymiarowa = new string[2, 3];
            //tabDwuWymiarowa[0, 0] = "a";
            //tabDwuWymiarowa[0, 1] = "b";

            //string[][] tablicaTablica = new string[3][];
            //tablicaTablica[0] = new string[2];
            //tablicaTablica[1] = new string[3];
            //tablicaTablica[2] = new string[1];

            //List<string[]> listaTablica = new List<string[]>();
            //listaTablica.Add(new string[2]);
            //listaTablica.Add(new string[3]);
            //listaTablica.Add(new string[1]);

            //listaTablica[1][2] = "ala";

            string[] wiersze =
                dane.Split(new string[1] {"\r\n"},StringSplitOptions.RemoveEmptyEntries);

            List<string[]> wynik = new List<string[]>();
            for (int i = 1; i < wiersze.Length; i++)
                wynik.Add(wiersze[i].Split(';'));

            

        }
    }
}
