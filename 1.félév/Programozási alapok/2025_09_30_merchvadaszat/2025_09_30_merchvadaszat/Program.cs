using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2025_09_30_merchvadaszat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader r = new StreamReader("be1.txt");
            List<int> db = new List<int>();
            r.ReadLine();
            while (!r.EndOfStream)
            {
                db.Add(int.Parse(r.ReadLine()));
            }

            int sum = db[0];
            int maxIndex = 0;
            int maxValue = db[0];

            for (int i = 0; i < db.Count; i++)
            {
                sum += db[i];
                if(maxValue< db[i])
                {
                    maxIndex = i;
                    maxValue = db[i];
                }
            }

            Console.WriteLine("Összesen "+ sum + " darab cuccot szedett össze.");
            Console.WriteLine("A legtöbb cuccot a " +(maxIndex+1) +". standnál szedte. Ez "+ maxValue+ " db volt.");

            Console.ReadKey();
        }
    }
}
