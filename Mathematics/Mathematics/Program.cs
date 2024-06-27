using System;

namespace Mathematics
{
    class Program
    {
        static void Main()
        {
            int t = int.Parse(Console.ReadLine());
            int result = 0;
            for (int i = 0; i < t; i++)
            {
                int a = int.Parse(Console.ReadLine());
                result += a;
            }
            Console.WriteLine(result);
        }
    }
}