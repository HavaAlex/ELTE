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
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("==========================================");
            Console.WriteLine("Az Alex féle téglalap terület számító 5000");
            Console.WriteLine("==========================================");
            Console.ForegroundColor = ConsoleColor.White;
            try
            {
                if(error != "")
                { 
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(error);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.Write("a = ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.Write("b = ");
                double b = Convert.ToDouble(Console.ReadLine());
                if (a == 0 || b == 0)
                {
                    
                    AskQuestion("Nem lehet 0");
                }
                else if (a < 0 || b < 0)
                {
                    
                    AskQuestion("Nem lehet negatív");
                }

                else
                {
                    Console.WriteLine(a * b + " lett az eredmény");
                    Console.WriteLine($"{a * b} lett az eredmény");

                    Console.Write("Akarod újra? (y/n): ");
                    string answer = Console.ReadLine();
                    answer = answer.ToLower();
                    if (answer == "y" || answer == "yes" )
                    {
                        error = "";
                        ;
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
                
                AskQuestion("Nem emgfelelő a bemeneti formátum (szám legyen)(törtet ,-vel válaszd el ne .-val)");
            }
            catch
            {
                AskQuestion("Nem tudom ezt hogy hoztad össze de ne csináld");
            }
            
        }
    }
}
