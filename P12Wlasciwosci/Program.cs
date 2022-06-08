using P14Biblioteka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12Wlasciwosci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Czlowiek c = new Czlowiek();

            // string[] s = { "a", "b" };
            c.Imie = "Jan";
            c.Nazwisko = "Kowalski";

            c.Kraj = "polska"; //set
            string s = c.Kraj; // get

            Console.WriteLine(s);

            c.ImieNazwisko = "adam nowak";

            Console.WriteLine(c.ImieNazwisko);


            StringBuilder sb = new StringBuilder();
            
        }
    }
}
