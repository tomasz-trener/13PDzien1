using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03Tablice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] tablica1 = new string[3];
            int[] liczby = new int[4];
            bool[] zniemienneLogiczne = new bool[4];
            char[] tablicaZnakow = new char[4];

           // string dlugosc = liczby[0].ToString();

            string[] tablica2 = new string[3]
            {
                "ala", "ma", "kota"
            };

            string[] tablica3 = new string[]
            {
                "ala", "ma"
            };

            string[] tablca4 = { "ala", "ma", "kota" };

            Console.WriteLine(tablica1[0]);

            tablca4[1] = "bedzie miala";

            tablca4[tablca4.Length-1]=
                tablca4[tablca4.Length - 1].ToUpper();

            string napis = "ala ma+kota";

            string[] wyrazy= napis.Split(' ','+');

            string napis2 = "ala!*ma!*kota**i**ma@@kota";

            string[] rozdzielacze = { "!*", "**", "@@" };
            string[] wyrazy2 = napis.Split(rozdzielacze,StringSplitOptions.RemoveEmptyEntries);

            string[] wyrazy3 = napis.Split(new string[] { "!*", "**", "@@" }, StringSplitOptions.RemoveEmptyEntries);

            string[] wyrazy4= napis.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            Console.ReadKey();






        }
    }
}
