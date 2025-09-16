
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2025_09_16_faktorialiszamito
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
                    Console.Write("Mi a számod papi? : ");
                    int a = int.Parse(Console.ReadLine());
                    Console.WriteLine(a+"! = " + Enumerable.Range(1, a).Aggregate(1, (p, item) => p * item));
                }
                catch
                {
                    Console.WriteLine("Azt hitted nem számolok ezzel? Nem baj, jó probálkozás volt.");
                }
                Console.WriteLine("Nyomjon meg bármilyen gombot, hogy újrakezdje");
                Console.ReadKey();  
            }
        }
    }
}
