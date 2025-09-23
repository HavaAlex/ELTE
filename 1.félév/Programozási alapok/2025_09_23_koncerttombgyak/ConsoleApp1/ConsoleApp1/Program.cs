using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        //static Dictionary<string,int> keyValuePairs = new Dictionary<string,int>();
        
        static string[] zenekar = { "Pamkutya", "Metallica", "Azahriah", "Rúzsa Magdi", "Rammstein" };
        static int[] hanyszor = { 4, 2, 3, 2, 2 };
        static void Main(string[] args)
        {/*
            keyValuePairs.Add("Pamkutya", 4);
            keyValuePairs.Add("Metallica", 2);
            keyValuePairs.Add("Azahriah", 3);
            keyValuePairs.Add("Rúzsa Magdi", 2);
            keyValuePairs.Add("Rammstein", 2);*/

            while (true)
            {
                try
                {
                    Console.Write("Melyik zenekarra vagy kíváncsi? : ");
                    string z = Console.ReadLine();/*
                    for (int i = 0; i < zenekar.Length; i++)
                    {
                        if (zenekar[i] == z)
                        {
                            Console.WriteLine("A " + z + " zenekar " + hanyszor[i] + "-szer koncertezett zsinórban." );
                        }
                    }*/
                    int i = 0;
                    while (zenekar[i] != z)
                    {
                        i++;
                    }
                    int db = hanyszor[i];
                    Console.WriteLine("A " + z + " zenekar " + db + "-szer koncertezett zsinórban.");
                }
                catch 
                {
                    Console.WriteLine("Nem nyert");
                }
                Console.ReadKey();  
            }
        }
    }
}
