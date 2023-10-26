using System;

namespace Uppgift_3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" antal minuter:");
            int minuter = int.Parse(Console.ReadLine());
            Console.WriteLine(" antal sekunder:");
            int sekunder = int.Parse(Console.ReadLine());

            int totalSekunder = minuter * 60 + sekunder;
            int minTidSekunder = 2 * 60 + 45; 
            int maxTidSekunder = 4 * 60 + 20; 
            if (totalSekunder >= minTidSekunder && totalSekunder <= maxTidSekunder)
            {
                Console.WriteLine("Låten får spelas på radiostationen.");
            }
            else
            {
                Console.WriteLine("Låten får inte spelas på radiostationen.");
            }
        }
    }
}




