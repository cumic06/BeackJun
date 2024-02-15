using System;

namespace A_B_5
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] st = Console.ReadLine().Split();

                if (int.Parse(st[0]).Equals(0) || int.Parse(st[1]).Equals(0)) break;

                int a = int.Parse(st[0]);
                int b = int.Parse(st[1]);

                Console.WriteLine(a + b);
            }
        }
    }
}
