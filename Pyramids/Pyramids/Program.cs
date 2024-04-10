using System;

namespace Pyramids
{
    class Program
    {
        static void Main()
        {
            int a = 1;
            while (a != 0)
            {
                int b = 0;
                a = int.Parse(Console.ReadLine());
                for (int i = 1; i <= a; i++)
                {
                    b += i;
                }
                if (a == 0) return;
                Console.WriteLine(b);
            }
        }
    }
}