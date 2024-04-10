using System;
using System.Numerics;

namespace BigIntA_B
{
    class Program
    {
        static void Main()
        {
            string[] s = Console.ReadLine().Split();
            BigInteger a = BigInteger.Parse(s[0].ToString());
            BigInteger b = BigInteger.Parse(s[1].ToString());

            Console.WriteLine(a + b);
        }
    }
}