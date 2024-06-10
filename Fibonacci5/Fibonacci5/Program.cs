using System;

namespace Fibonacci5
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int fibonacciValue = 0;
            fibonacciValue += Fibonacci(n);
            Console.WriteLine(fibonacciValue);
        }

        static int Fibonacci(int a)
        {
            if (a == 0)
            {
                return 0;
            }
            if (a == 1)
            {
                return 1;
            }
            return Fibonacci(a - 1) + Fibonacci(a - 2);
        }
    }
}