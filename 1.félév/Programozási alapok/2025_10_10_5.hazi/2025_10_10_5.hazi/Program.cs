using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2025_10_10_5.hazi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader r = new StreamReader("Test.txt");
            int k = int.Parse(r.ReadLine());
            int[] baskets = new int[k];
            baskets = Array.ConvertAll(r.ReadLine().Split(' ').ToArray(),s=>int.Parse(s));
            int ind = 0;
            for (int i = 1; i < baskets.Length; i++)
            {
                if (baskets[i] > baskets[ind])
                {
                    ind = i;
                }
            }
            Console.WriteLine("Az első teli kosár a "+ (ind+1) + ". napon volt.");
            Console.ReadKey();
        }
    }
}
