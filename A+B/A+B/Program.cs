using System;

namespace A_B
{
    class Program
    {
        static void Main()
        {
            string[] str = Console.ReadLine().Split();
            int a = int.Parse(str[0]);
            int b = int.Parse(str[1]);

            Console.WriteLine(a + b);
        }
    }
}
