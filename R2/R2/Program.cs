using System;

namespace R2
{
    class Program
    {
        static void Main()
        {
            string[] str = Console.ReadLine().Split();
            int r1 = int.Parse(str[0]);
            int s = int.Parse(str[1]);

            Console.WriteLine(s * 2 - r1);
        }
    }
}