using System;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            bool joe = false;
            do
            {
                Console.Error.WriteLine("Add meg az n értékét: ");

                joe = int.TryParse(Console.ReadLine(), out n) && (n >= 0 && n <= 100);
                if (!joe)
                {
                    Console.Error.WriteLine("Hiba");
                }
            } while (!joe);
            int[] m = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Error.WriteLine("adjad meg tesó: ");
                m[i] = Convert.ToInt32(Console.ReadLine());
            }


            int db = 0;
            for (int i = 0; i < n; i++)
            {
                if (m[i] > 0)
                {
                    db = db + 1;
                }
            }
            Console.Error.WriteLine("Ennyiszer esett: ");
            Console.WriteLine(db);
            

        }
    }
}
