using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P14Biblioteka
{
    public class Czlowiek
    {
        public string Imie;

        public string Nazwisko { get; set; }

        private string kraj;

        public string Kraj
        {
            get
            {
                return kraj.Substring(0, 3);
            }
            set
            {
                string s = value; //s="pol"
                s = s.ToUpper();
                kraj = s;
            }
        }

        public string ImieNazwisko
        {
            set
            {
                Imie = value.Split(' ')[0];
                Nazwisko = value.Split(' ')[1];
            }
            get { return Imie + " " + Nazwisko; }
        }


        private int wzrost;

        public int Wzrost
        {
            get { return wzrost; }
            set { wzrost = value; }
        }


    }
}
