using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Másodperckonvertál
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string error = "";
            AskQueastion(error);
            Console.ReadKey();
        }

        static void AskQueastion(string error)
        {
            Console.Clear();
            
            try
            {
                if (error != "")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(error);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.Write("Óra: ");
                double Hour = Convert.ToDouble(Console.ReadLine());
                Console.Write("Perc: ");
                double Minute = Convert.ToDouble(Console.ReadLine());
                Console.Write("Óra: ");
                double Second = Convert.ToDouble(Console.ReadLine());
                if (Hour < 0 || Minute < 0 || Second < 0)
                {
                    AskQueastion("Nem lehet negatív");
                }
                else
                {
                    Console.WriteLine("Az eredmény: " + (Hour * 3600 + Minute * 60 + Second) + " másodperc");
                    Console.WriteLine("Jöhet mégegy (y/n): ");
                    string answer = Console.ReadLine();
                    answer = answer.ToLower();
                    if (answer == "y" || answer == "yes")
                    {
                        error = "";
                        
                        AskQueastion(error);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Mindegy amúgysem akartam, lépj ki nyugodtan");
                    }

                }
            }
            catch (System.FormatException) 
            {
                AskQueastion("Számot írjál légyszi");
            }
            catch 
            {
                Console.WriteLine("Nem tudom hogy hoztad össze de hagyd inkább a jövöben");
            }

        }
    }
}
