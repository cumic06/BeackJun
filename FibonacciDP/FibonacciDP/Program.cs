using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FibonacciDP
{
    class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int fibonacciCount = 0;
            for (int i = 0; i < a; i++)
            {
                fibonacciCount += Fibonacci(a);
            }
            Console.WriteLine(fibonacciCount);
        }

        static int Fibonacci(int a)
        {
            return a;
        }
        //static int FibonacciDP(int a)
        //{

        //}
    }
}
