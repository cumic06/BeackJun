using System;
using System.Numerics;

namespace Multiply
{
    class Program
    {
        static void Main()
        {
            string[] str = Console.ReadLine().Split();
            BigInteger a = BigInteger.Parse(Console.ReadLine());
            BigInteger b = BigInteger.Parse(Console.ReadLine());

            Console.WriteLine(a * b);
        }
    }
}