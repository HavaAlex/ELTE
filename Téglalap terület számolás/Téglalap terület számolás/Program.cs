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
            try
            {
                if(error != "")
                {
                    Console.WriteLine(error);
                }
                Console.Write("a = ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.Write("b = ");
                double b = Convert.ToDouble(Console.ReadLine());
                if (a == 0 || b == 0)
                {
                    Console.Clear();
                    AskQuestion("Nem lehet 0");
                }
                else if (a < 0 || b < 0)
                {
                    Console.Clear();
                    AskQuestion("Nem lehet negatív");
                }

                else
                {
                    Console.WriteLine(a * b + " lett az eredmény");
                    Console.WriteLine($"{a * b} lett az eredmény");

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
            catch (System.FormatException)
            {
                Console.Clear();
                AskQuestion("Nem emgfelelő a bemeneti formátum (szám legyen, törtet ,-vel válaszd el ne .-al)");
            }
            
        }
    }
}
