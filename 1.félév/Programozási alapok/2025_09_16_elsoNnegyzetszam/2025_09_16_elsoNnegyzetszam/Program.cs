
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
                    Console.Write("Adja meg hány négyzetszámot adjak össze: ");
                    int n = int.Parse(Console.ReadLine());
                    List<int> list = new List<int>();
                    Console.WriteLine("Az első "+n+ " négyzetszám összege: "+ Enumerable.Range(1, n).Aggregate(0,(p,item) => p+=item*item));

                }
                catch 
                {
                    Console.WriteLine("Tudhatnád hogy velem nem szabad packázni >:)");
                }
                Console.WriteLine("Az újrakezdéshez nyomja meg bármely gombot");
                Console.ReadKey();
            }
        }
    }
}
