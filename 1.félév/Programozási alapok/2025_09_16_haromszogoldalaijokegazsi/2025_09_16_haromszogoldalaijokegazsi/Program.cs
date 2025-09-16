using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2025_09_16_haromszogoldalaijokegazsi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) 
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("======================================================================================");
                Console.WriteLine("||Hihetetlen hárömszög validátor 5000 ELTE IK módra (sok tervezés még több szeretet)||");
                Console.WriteLine("======================================================================================");
                Console.ForegroundColor = ConsoleColor.White;
                double a, b, c;
                bool ok;
                try
                {
                    Console.Write("A oldal: ");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.Write("B oldal: ");
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.Write("C oldal: ");
                    c = Convert.ToDouble(Console.ReadLine());

                    if ((a < b + c) && (b < a + c) && (c < a + b))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Ügyes vagy megoldottad");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ez se megy te suta pupák!");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                catch 
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Vagy rosszul irtad be vagy nagy mágus vagy. A lényeg hogy próbáld újra köszi");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                
                Console.WriteLine("Ha még egy érdekelne nyomj meg bármit és újrakezdődik");
                Console.WriteLine("Ha nem ikszeld ki nem bánom tényleg nem zavar egyáltalán amúgy is lenne dolgom *elpirul és beszarik ");
                Console.ReadKey();
            }
            

            Console.ReadKey();
        }
    }
}
