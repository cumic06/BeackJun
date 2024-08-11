using System;

namespace MemorizingTriangle
{
    internal class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if (a == 60 && b == 60 && c == 60)
            {
                Console.WriteLine("Equilateral");
            }
            else if (a + b + c == 180 && (a == b || b == c || c == a))
            {
                Console.WriteLine("Isosceles");
            }
            else if (a + b + c == 180 && a != b && b != c && a != c)
            {
                Console.WriteLine("Scalene");
            }
            else if (a + b + c != 180)
            {
                Console.WriteLine("Error");
            }
        }
    }
}