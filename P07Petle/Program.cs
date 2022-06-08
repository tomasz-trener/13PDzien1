using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07Petle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            if (a<10)
                a++;
            
            while (a<10)
                Console.WriteLine(++a);

            a--;
            --a;

            a += 3; // a = a+3;
            a = +3; // a = 3      
            a *= 4; // a = a*4



            do
            {
                Console.WriteLine(a++);
            } while (a<10);


            for (int i = 10; i < 20; i+=2)
                Console.WriteLine(i);
            

            for (int i = 0; i < 10; i++)
            {

            }

            string[] napisy = { "ala", "ma", "kota" };

            for (int i = 0; i < napisy.Length; i++)
                Console.WriteLine(napisy[i]);

            foreach (var k in napisy)
                Console.WriteLine(k);


            Console.ReadKey();
        }
    }
}
