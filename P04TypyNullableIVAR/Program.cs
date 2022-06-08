using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04TypyNullableIVAR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            string b = "ala";

            var c = "ala"; // zmienna c to string 
            var d = 6;

            dynamic e = "ala";
            e = 5;

            var napisy = new string[3] { "ala", "ma", "kota" };

            int? f = null;
            string g = null;


            int?[] tablica = new int?[4];

            DateTime? h = null;

            DateTime[] tablicaDat = new DateTime[2];
        }
    }
}
