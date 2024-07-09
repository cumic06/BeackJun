using System;

namespace Triangle
{
    class Program
    {
        static void Main()
        {
            string[] str = Console.ReadLine().Split();

            float a = float.Parse(str[0]);
            float b = float.Parse(str[1]);

            float c = a * b * 0.5f;
            Console.WriteLine($"{c:0.0}");
        }
    }
}