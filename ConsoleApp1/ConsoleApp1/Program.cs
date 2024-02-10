using System;

namespace Pibonachi
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 1;

            int n = int.Parse(Console.ReadLine());

            if (n <= 90)
            {
                for (int i = 0; i < n; i++)
                {
                    int c = a + b;
                    a = b;
                    b = c;
                }
                Console.WriteLine(a);
                Console.ReadKey();
            }
        }
    }
}
