using System;

namespace Factorial2
{
    class Program
    {
        static void Main()
        {
            long n = long.Parse(Console.ReadLine());

            long result = 1;

            result = Factorial(n);
            Console.WriteLine(result);
        }

        static long Factorial(long n)
        {
            if (n <= 1)
            {
                return 1;
            }
            else
            {
                long result = n * Factorial(n - 1);
                return result;
            }
        }
    }
}