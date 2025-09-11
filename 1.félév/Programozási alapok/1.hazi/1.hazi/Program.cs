using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.hazi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AskQuestion("");
            Console.ReadKey();
        }
        static void AskQuestion(string ErrorMessage)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("====================================================================");
            Console.WriteLine("||Nekeresdi csúszdapark kedvezményjogosultság megállapító rendszer||");
            Console.WriteLine("====================================================================");
            Console.ForegroundColor = ConsoleColor.White;
            if (ErrorMessage != "")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ErrorMessage);
                Console.ForegroundColor= ConsoleColor.White;
            }
            try
            {
                Console.Write("Adja meg az ügyfél életkorát: ");
                int kor = int.Parse(Console.ReadLine());
                if (JogosultE(kor))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Kedvezményre jogosult");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Nyomja meg bármely gombot az új szám beírásához");
                    
                    Restart();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Kedvezményre nem jogosult");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Nyomja meg bármely gombot az új szám beírásához");
                    Restart();
                }

            }
            catch (System.FormatException)
            {
                AskQuestion("Egész, nem negatív számot adjon meg!");
                
            }
        }

        static bool JogosultE(int kor)
        {
            if (kor > 60 || kor < 16)
            {
                return true;
            }
            else {
            return false;
            }
        }

        static void Restart()
        {
            Console.ReadLine();
            AskQuestion("");
        }
    }
}
