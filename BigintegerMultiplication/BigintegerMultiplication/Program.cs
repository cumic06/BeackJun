using System;
using System.Numerics;

namespace BigintegerMultiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split();
            BigInteger a = BigInteger.Parse(str[0]);
            BigInteger b = BigInteger.Parse(str[1]);

            Console.WriteLine(a * b);
        }
    }
}