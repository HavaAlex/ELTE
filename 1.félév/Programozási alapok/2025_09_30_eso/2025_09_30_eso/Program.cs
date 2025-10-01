using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2025_09_30_eso
{
    internal class Program
    {
        static List<int> t = new List<int>();
        static void Main(string[] args)
        {  /*
            StreamReader r = new StreamReader("be1.txt");
            while (!r.EndOfStream)
            {
                t.Add(int.Parse(r.ReadLine()));
            }
            Console.Error.WriteLine(((t.Where(i => i > 0)).ToList()).Count + " alkalommal esett");
            */
            
            int n;
            bool joe = false;
            do
            {
                Console.Error.WriteLine("Add meg az n értékét: ");

                joe = int.TryParse(Console.ReadLine(), out n) && (n >= 0 && n <= 100);
                if (!joe)
                {
                    Console.Error.WriteLine("Hiba");
                }
            }while (!joe);
            int[] m = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Error.WriteLine("adjad meg tesó: ");
                m[i] = Convert.ToInt32(Console.ReadLine());
            }


            int db = 0;
            for (int i = 0; i < n; i++)
            {
                if (m[i] > 0)
                {
                    db = db + 1;
                }
            }
            Console.Error.WriteLine("Ennyiszer esett: ");
            Console.WriteLine(db);
           
        }
    }
}
