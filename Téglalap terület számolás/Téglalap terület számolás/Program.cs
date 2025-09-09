using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Téglalap_terület_számolás
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string error = "";
            AskQuestion(error);
            Console.ReadKey();
        }
        static void AskQuestion(string error)
        {
            Console.WriteLine(error);
            Console.Write("Adja meg az egyik oldalt (egész szám legyen légyszi és ne 0 és ne negatív pliz pliz): ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Adja meg az másik oldalt (egész szám legyen légyszi és ne 0 és ne negatív pliz pliz): ");
            double b = Convert.ToDouble(Console.ReadLine());
            if (a == 0 || b == 0)
            {
                Console.Clear();
                AskQuestion("NE LEGYEN NULLA NAAAA");
            }
            else if (a < 0 || b < 0) 
            {
                Console.Clear();
                AskQuestion("Legyen már bozítív naaa");
            }
            else 
            {
                Console.WriteLine(a*b + " lett az eredmény");
                Console.Write("Akarod újra? (y/n)");
                string answer = Console.ReadLine();
                if (answer == "y" || answer == "yes") 
                {
                    error = "";
                    Console.Clear();
                    AskQuestion(error);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Mindegy amúgysem akartam, lépj ki nyugodtan");
                }

                //double tryParse(Console.Readline(), out a);

            }
        }
    }
}
