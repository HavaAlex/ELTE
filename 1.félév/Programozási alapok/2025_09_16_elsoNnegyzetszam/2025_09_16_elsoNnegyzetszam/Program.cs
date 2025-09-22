
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2025_09_16_elsoNnegyzetszam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                try
                {

                    Console.Write("Adja meg az első hány négzetszám összegére kiváncsi (1 és 20 közötti számot adjon meg): ");
                    int n = int.Parse(Console.ReadLine());
                    if (n<=20 && n>=1)
                    {
                        int ossz = Enumerable.Range(1, n).Aggregate(0, (p, item) => p += item * item);
                        Console.WriteLine("Az első " + n + " négyzetszám összege: " + ossz);
                        
                    }
                    else
                    {
                        Console.WriteLine("Túl nagy vagy túl kicsi számot adott meg");
                    }
                }
                catch 
                {
                    Console.WriteLine("Hiba! Nem egész számot adott meg! ");
                }
                Console.WriteLine("Az újrakezdéshez nyomja meg bármely gombot");
                Console.ReadKey();
            }
        }
    }
}
