using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2025_10_07_pecazas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] ints = new int[n];
            for (int i = 0; i < n; i++)
            {
                string temp = Console.ReadLine();
                ints[i] = int.Parse(temp);
            }
            int mindindex = -1;
            int temp2 = 0;
            bool found = false;
            while (temp2 < ints.Length && !found) 
            {
                if (ints[temp2] == 0)
                {
                    mindindex = temp2+1;
                    found = true;
                }
                else
                {
                    
                    temp2++;
                }
            }
            Console.WriteLine(mindindex);
        }
    }
}
