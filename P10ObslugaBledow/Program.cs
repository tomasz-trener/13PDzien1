using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10ObslugaBledow
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] n = new string[3];
            int a = 0;
            n[0] = "x";
           
            try
            {
                int b = 5 / a;
                n[3] = "a";

                int c = Convert.ToInt32(n[0]);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("podales zbyt duz indeks");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Nie mozesz dzielic przez 0");
            }
            catch (Exception ex)
            {
                Console.WriteLine("nieznany błąd");
                File.WriteAllText("c:\\bledy\\error.txt", ex.Message);
            }

            Console.WriteLine("koniec programu");


        }
    }
}
