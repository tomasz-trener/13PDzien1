using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05Listy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] tablica = new string[3];

            List<string> lista1 = new List<string>();

            var lista2 = new List<string>();
            List<string> lista3 = null;
            Console.WriteLine(lista2.Count);
            
            lista2.Add("ala");
            lista2.Add("ma");
            lista2.Add("kota");
            lista2.Insert(0, "mala");

            lista2.Remove("ma");
            lista2.RemoveAll(cos => cos == "ma");
            lista2.RemoveAll(cos => cos.Contains("ma"));
            lista2.RemoveRange(1, 2); // od pozycji ile 
            lista2.RemoveAt(0); // na pozycji

            string[] tablica2 = lista2.ToArray();
            List<string> lista4 = tablica2.ToList();


            List<string> lista5 = lista4; // referencja 
            List<string> lista6 = lista4.ToList(); // kopia







        }
    }
}
