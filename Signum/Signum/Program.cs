using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AskQuestion("");
            Console.ReadKey();
        }
        static void AskQuestion(string error)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=========================================================================================");
            Console.WriteLine("Az Alex féle signum sebezhetetlen függvény rekurziós hibakezeléses 800 kredites programja");
            Console.WriteLine("=========================================================================================");
            Console.ForegroundColor = ConsoleColor.White;
            try
            {
                if (error != "")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(error);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.Write("a = ");
                double a = Convert.ToDouble(Console.ReadLine());
                if (a == 0 )
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("0");
                    Console.ForegroundColor = ConsoleColor.White;
                    restart("");
                }
                else if (a < 0 )
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("-1");
                    Console.ForegroundColor = ConsoleColor.White;
                    restart("");
                }

                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("1");
                    Console.ForegroundColor = ConsoleColor.White;
                    restart("");
                }
            }
            catch (System.FormatException)
            {

                AskQuestion("Nem emgfelelő a bemeneti formátum (szám legyen)");
            }
            catch
            {
                AskQuestion("Nem tudom ezt hogy hoztad össze de ne csináld");
            }
        }

        static void restart(string error)
        {
            Console.Write("Akarod újra? (y/n): ");
            string answer = Console.ReadLine();
            answer = answer.ToLower();
            if (answer == "y" || answer == "yes")
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
        }
    }
}
