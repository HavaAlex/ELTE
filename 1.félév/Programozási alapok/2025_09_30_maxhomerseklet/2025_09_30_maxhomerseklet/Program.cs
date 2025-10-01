using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2025_09_30_maxhomerseklet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader r = new StreamReader("be1.txt");
            r.ReadLine();
            List<int> hi = new List<int>();
            while (!r.EndOfStream) 
            { 
                hi.Add(int.Parse(r.ReadLine()));
            }
            int maxnap = 0;
            int maxho = 0;
            for (int i = 0; i < hi.Count; i++)
            {
                if (hi[i] > maxho)
                {
                    maxnap = i;
                    maxho = hi[i];
                }
            }
            Console.WriteLine("max hőmérséklet: "+ maxho);
            Console.WriteLine("ez a " + maxnap + ". napon volt");
            Console.ReadKey();
        }
    }
}
