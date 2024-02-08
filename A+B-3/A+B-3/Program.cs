using System;

namespace A_B_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] str = Console.ReadLine().Split();

                int a = int.Parse(str[0]);
                int b = int.Parse(str[1]);

                if (b < 10 && a < 10 && b > 0 && a > 0)
                {
                    Console.WriteLine(a + b);
                }
            }
        }
    }
}
