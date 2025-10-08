using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _2025_10_07
{
    struct Diak
    {
        public string nev;
        public int kor;
    }
    internal class Program
    {
       
        static void Main(string[] args)
        {
            int n; //kezdem elfelejteni azt aki egykor voltam.
            /*itt vagyok és tömböt használok lista helyett. Elbuktam mint férfi,
             mint férj, mint apa és mint fiú. Feladatam az elveimet a 
            kapzsiság (programtervező informatikus diploma) oltárán. Lassan
            eltűnök és senki se fog emlékezni rám. ;(
            */
            bool joe;
            do
            {
                  joe = int.TryParse(Console.ReadLine(), out n) && n<=45 && n>=3;
            }while(joe);
            Diak[] osztaly = new Diak[n];/*
            string s;
            s = Console.ReadLine();
            Console.WriteLine(s);
            string[] darabok = s.Split();*/
            string[] s = Console.ReadLine().Split();
            for (int i = 0; i < n; i++) {
                s= Console.ReadLine().Split();
                osztaly[i].nev = s[0];
                osztaly[i].kor = Convert.ToInt32(s[1]);
            }



            bool van = false;
            int j = 0;
            while (j < n && !van) 
            {
                if (osztaly[j].kor < 18)
                {
                    van = true;
                }
                else
                {
                    j++;
                }
            }
            Console.ReadKey();
        }
    }
}
