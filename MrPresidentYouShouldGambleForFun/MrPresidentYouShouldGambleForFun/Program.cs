using System;

namespace MrPresidentYouShouldGambleForFun
{
    internal class Program
    {
        static void Main()
        {
            int total = 0;
            while (true)
            {
                int a = int.Parse(Console.ReadLine());
                if (a == -1) break;
                total += a;
            }
            Console.WriteLine(total);
        }
    }
}