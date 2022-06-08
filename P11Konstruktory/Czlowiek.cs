using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11Konstruktory
{
    internal class Czlowiek
    {
        public string Imie;
        public string Nazwisko;
        public string Kraj;

        public Czlowiek()
        {
            Imie = "jan";
            Nazwisko = "kowalski";
        }


        public Czlowiek(string imie, string nazwisko)
        {
            Imie = imie;
            Nazwisko = nazwisko;
        }

        public Czlowiek(string imie, string nazwisko, string kraj = "pol") : this(nazwisko, imie)
        {
            Kraj = kraj;
        }


        public string PrzestawSie()
        {
            string w = $"nazywam sie {Imie} {Nazwisko}";

            return w;

        }
    }
}
