using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02WejscieWyjcie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("podaj jak sie nazywasz");

            //string imie = Console.ReadLine();

            //Console.WriteLine("podaj wiek");

            //string wiek = Console.ReadLine();

            //int liczba = Convert.ToInt32(wiek);

            short malaLiczba = 5; // int16 
            long duzaLiczba = 5; // int64 

            string data = "2020-01-20";

            DateTime dt = Convert.ToDateTime(data);

            DateTime dzis = DateTime.Now;

            Console.WriteLine(dzis);

            string wynik = dzis.ToString("dd-MMMM-yyyy");
            Console.WriteLine(wynik);

            int misiac= dzis.Month;



            Console.ReadKey();

        }
    }
}
