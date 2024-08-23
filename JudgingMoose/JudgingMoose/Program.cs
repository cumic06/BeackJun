using System;

namespace JudgingMoose
{
    internal class Program
    {
        static void Main()
        {
            string[] strArray = Console.ReadLine().Split();

            int a = int.Parse(strArray[0]);
            int b = int.Parse(strArray[1]);

            if (a == 0 && b == 0)
            {
                Console.WriteLine("Not a moose");
                return;
            }

            if (a == b)
            {
                Console.WriteLine($"Even {a + b}");
            }
            else
            {
                if (a > b)
                {
                    Console.WriteLine($"Odd {a * 2}");
                }
                else if (a < b)
                {
                    Console.WriteLine($"Odd {b * 2}");
                }
            }
        }
    }
}