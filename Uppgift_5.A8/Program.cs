using System;
namespace Uppgift_5_A8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] talArr = { 25, 68, 240, 398, 13393 };
            
            foreach (int tal in talArr)
            {
                for (int i = 0; i < tal.ToString().Length; i++)
                {
                    Console.Write(tal.ToString()[i]);
                    Task.Delay(500).Wait();
                }
                Task.Delay(1000).Wait();
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}