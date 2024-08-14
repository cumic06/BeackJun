using System;

namespace SpecialDay
{
    internal class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (a > 2)
            {
                Console.WriteLine("After");
            }
            else if (a == 2)
            {
                if (b > 18)
                {
                    Console.WriteLine("After");
                }
                else if (b == 18)
                {
                    Console.WriteLine("Special");
                }
                else
                {
                    Console.WriteLine("Before");
                }
            }
            else
            {
                Console.WriteLine("Before");
            }
        }
    }
}