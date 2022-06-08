using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P09ProgramowanieObiektoweWstep
{
    internal class Kalkulator
    {

        //1) Pola -> cechy danego obiektu  np: waga
        //2) Właściwości -> cechy obiektu ale troszkę bardziej rozbudowane 
        //3) Konstruktory -> okrela w jaki sposob mozemy tworzyc dany obiekt 
        //4) Metody -> umiejetność danego obiektu np: Dodaj dwie liczby 

        private int waga;

        public string Kolor;
        public int? Szerokosc;

        public static int LiczbaDostepnychCyfr;

        private int dodaj(int a, int b)
        {
            if (a <= LiczbaDostepnychCyfr && b<=LiczbaDostepnychCyfr)
            {
                int x = a;
                int y = b;
                int wynik = x + y;
                return wynik;
            }

            throw new Exception("Przekroczenie wartosci liczby dotepnych cyfr");
        }

        //public double Podziel(int a, int b)
        //{
        //    if (b==0)
        //        throw new Exception("Nie mozesz dzielic przez 0");

        //    return a / b;
        //}
        public double Podziel(int a, int b)
        {
            try
            {
                return a / b;
            }
            catch (Exception)
            {
                throw;
            }

           
        }


        /// <summary>
        /// Ta metoda sluzy do mnozenia
        /// </summary>
        /// <param name="a">liczba piersza</param>
        /// <param name="b">liczba druga</param>
        /// <returns>wynik mnozenia</returns>
        public int Przemnoz(int a, int b)
        {
            int w = a;
            for (int i = 0; i < b; i++)
                w = dodaj(w, a);

            return w;
            // return a * b;
        }




    }
}
