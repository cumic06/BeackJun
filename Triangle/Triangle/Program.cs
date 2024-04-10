using System;

namespace Triangle
{
    class Program
    {
        static void Main()
        {
            string[] str = Console.ReadLine().Split();
            int a = int.Parse(str[0]);
            int b = int.Parse(str[1]);
            float c = a * b * 0.5f;
            Console.WriteLine($"{c:0.0}");
        }
    }
}