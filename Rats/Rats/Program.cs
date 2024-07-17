using System;

namespace Rats
{
    class Program
    {
        static void Main()
        {
            string[] str = Console.ReadLine().Split();
            int a = int.Parse(str[0]);
            int b = int.Parse(str[1]);
            int c = int.Parse(str[2]);

            int d = (a + 1) * (b + 1) / (c + 1) - 1;

            Console.WriteLine(d);
        }
    }
}