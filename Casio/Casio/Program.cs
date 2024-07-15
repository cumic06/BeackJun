using System;

namespace Casio
{
    class Program
    {
        static void Main()
        {
            string[] str = Console.ReadLine().Split();
            long a = long.Parse(str[0]);
            long b = long.Parse(str[1]);

            if (a == b)
            {
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}