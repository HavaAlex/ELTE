using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace code
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
                    Console.Write("Adja meg az osztandót: ");
                    int a = int.Parse(Console.ReadLine());
                    Console.Write("Adja meg az osztót: ");
                    int b = int.Parse(Console.ReadLine());
                    while (a > b)
                    {
                        a -= b;
                    }
                    Console.WriteLine("A maradék természetesen: "+ a);
                }
                
                catch
                {
                    Console.WriteLine("Látom a számok nincsenek meg");
                    
                }
                Console.ReadKey();
            }
            

            Console.ReadKey();
        }
    }
}
