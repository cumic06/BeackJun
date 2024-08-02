using System;

namespace WhichAlien
{
    class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (a >= 3 && b <= 4)
            {
                Console.WriteLine("TroyMartian");
            }
            if (a <= 6 && b >= 2)
            {
                Console.WriteLine("VladSaturnian");
            }
            if (a <= 2 && b <= 3)
            {
                Console.WriteLine("GraemeMercurian");
            }
        }
    }
}