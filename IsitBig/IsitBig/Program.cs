using System;

namespace IsitBig
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                string[] a = Console.ReadLine().Split();
                if (int.Parse(a[0]) == 0) break;

                int b = int.Parse(a[0]);
                int c = int.Parse(a[1]);

                if (b > c) Console.WriteLine("Yes");
                if (b <= c) Console.WriteLine("No");
            }
        }
    }
}