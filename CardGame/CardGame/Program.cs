using System;

namespace CardGame
{
    class Program
    {
        static void Main()
        {
            int b = 0;
            for (int i = 0; i < 5; i++)
            {
                int a = int.Parse(Console.ReadLine());
                b += a;
            }
            Console.WriteLine(b);
        }
    }
}
