using System;
using System.Linq;

namespace MinMax
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            string[] numString = new string[n];
            numString = Console.ReadLine().Trim().Split();
            int[] numInt = new int[n];

            for (int i = 0; i < numString.Length; i++)
            {
                numInt[i] = int.Parse(numString[i]);
            }
            Console.WriteLine($"{numInt.Min()} {numInt.Max()}");
        }
    }
}