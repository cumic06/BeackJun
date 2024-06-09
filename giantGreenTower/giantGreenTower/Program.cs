using System;

namespace giantGreenTower
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int result = 1;

            for (int i = 0; i < n; i++)
            {
                result *= 2;
            }
            Console.WriteLine(result);
        }
    }
}