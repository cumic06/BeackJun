using System;

namespace Tax
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int a = n - (int)(n * 0.22f);
            int b = n - (int)(n * 0.2f * 0.22f);

            Console.WriteLine($"{a} {b}");
        }
    }
}