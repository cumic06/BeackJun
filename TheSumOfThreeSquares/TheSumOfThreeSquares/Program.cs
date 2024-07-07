using System;

namespace TheSumOfThreeSquares
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int a = 0;
            int b = 0;
            int c = 0;

            for (int i = 1; i <= n; i++)
            {
                a += i;
                b += i;
                c += i * i * i;
            }
            b *= b;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}