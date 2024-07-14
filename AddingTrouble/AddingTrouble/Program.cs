using System;

namespace AddingTrouble
{
    class Program
    {
        static void Main()
        {
            string[] str = Console.ReadLine().Split();
            int a = int.Parse(str[0]);
            int b = int.Parse(str[1]);
            int c = int.Parse(str[2]);

            if (a + b == c)
            {
                Console.WriteLine("correct!");
            }
            else
            {
                Console.WriteLine("wrong!");
            }
        }
    }
}