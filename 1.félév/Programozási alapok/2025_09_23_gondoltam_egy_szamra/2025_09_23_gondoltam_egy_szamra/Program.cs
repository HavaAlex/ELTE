using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2025_09_23_gondoltam_egy_szamra
{
    internal class Program
    {
        static Random rnd = new Random();
        static ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
        static void Main(string[] args)
        {
            while (true) {
                int i = rnd.Next(0, colors.Length);
                Console.BackgroundColor = colors[i];
                Console.ForegroundColor = colors[colors.Length - i - 1];
                Game();
            }
            
            
            Console.ReadKey();  
        }
        static void Game()
        {
            
            int Number = rnd.Next(0, 101);
            int PlayerNumber = -1;
            while (PlayerNumber != Number)
            {
                Console.Write("Gondoltam egy számra! Szerinted mi az: ");
                PlayerNumber = Convert.ToInt32(Console.ReadLine());
                int ResponseType = rnd.Next(0, 5);
                if (PlayerNumber < Number)
                {
                    Console.WriteLine("A számod kissebb mint az enyém.");
                }
                else if (PlayerNumber > Number)
                {
                    Console.WriteLine("A számod nagyobb mint az enyém.");
                }
            }
            Console.WriteLine("Gratulálok eltaláltad! A számom tényleg " + Number);
            Console.WriteLine("====================================================");
        }
    }
}
