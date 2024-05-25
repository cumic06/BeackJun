using System;

namespace FibonacciDP
{
    class Program
    {
        static int DPCount = 0;

        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            FibonacciDP(a);
            Console.WriteLine($"{Fibonacci(a)} {DPCount}");
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

        static int[] dp = new int[100];

        static int FibonacciDP(int a)
        {
            if (a == 0)
            {
                return 0;
            }
            if (a == 1 || a == 2)
            {
                return 1;
            }

            if (dp[a] != 0)
            {
                return dp[a];
            }

            DPCount++;
            return dp[a] = FibonacciDP(a - 1) + FibonacciDP(a - 2);
        }
    }
}
