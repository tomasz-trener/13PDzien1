using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11Konstruktory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Czlowiek c = new Czlowiek("adam","nowak");

            Console.WriteLine(c.PrzestawSie());

            Console.ReadKey();
        }
    }
}
