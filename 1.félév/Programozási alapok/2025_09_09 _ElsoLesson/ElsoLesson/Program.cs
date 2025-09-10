using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElsoLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
            Random random = new Random();
            while (true)
            {
                for (int k = 0; k < 15; k++)
                {
                    int i = random.Next(0, colors.Length);
                    Console.BackgroundColor = colors[i];
                    Console.ForegroundColor = colors[colors.Length - i - 1];
                    string[] Words = { "Anyádat", "Faszom", "Picsába", "Seggem", "Baszdmeg" };
                    int j = random.Next(0, Words.Length);
                    Console.Write(Words[j]);
                }
                
                Console.ResetColor();
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
