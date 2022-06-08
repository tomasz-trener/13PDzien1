using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06TypyReferencyjneIWartosciowe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = a; // kopia 
            a++;

            string c = "ala";
            string d = c; // kopia 
            c = "x";

            //a =6
            //b = 5

            string[] tablica1 = { "ala", "ma", "kota" };
            string[] tablica2 = tablica1; 
            tablica2[0] = "x";

            // listy i tablice przekazywane są przez referencje 

            // wszystkie struktury przekazywane sa przez wartosc;

            DateTime d1 = new DateTime();
            DateTime d2 = d1;
            d2= d2.AddMonths(1);

            // wszystkie klasy przeykazywane sa przez referencje 
            // wyjatkiem jest string 

            StringBuilder sb = new StringBuilder();
            sb.Append("ala ");
            sb.Append("ma ");
            sb.Append("kota");

            string wynik = sb.ToString();

            StringBuilder sb2 = sb; // to przekazanie przez referencje 

            string wynik1= sb2.ToString();

            



        }
    }
}
