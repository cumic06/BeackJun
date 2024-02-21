using System;
using System.Linq;
namespace Average
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string[] score = Console.ReadLine().Split();

            int[] scoreInt = Array.ConvertAll(score, s => int.Parse(s));

            int highValue = scoreInt.Max();

            double a = 0;

            for (int i = 0; i < n; i++)
            {
                a += double.Parse(score[i]) / highValue * 100;
            }
            double b = a / n;
            Console.WriteLine(b);
        }
    }
}
