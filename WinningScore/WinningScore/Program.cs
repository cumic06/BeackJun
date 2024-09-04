using System;

namespace WinningScore
{
    internal class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            int f = int.Parse(Console.ReadLine());
            int apples = a * 3 + b * 2 + c;
            int bananas = d * 3 + e * 2 + f;
            if (apples > bananas)
            {
                Console.WriteLine("A");
            }
            else if (apples < bananas)
            {
                Console.WriteLine("B");
            }
            else if (apples == bananas)
            {
                Console.WriteLine("T");
            }
        }
    }
}