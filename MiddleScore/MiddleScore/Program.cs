using System;

namespace MiddleScore
{
    class Program
    {
        static void Main()
        {
            int current = 0;
            for (int i = 0; i < 5; i++)
            {
                int a = int.Parse(Console.ReadLine());
                if (a < 40)
                {
                    a = 40;
                }
                current += a;
            }
            Console.WriteLine(current / 5);
        }
    }
}