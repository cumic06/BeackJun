using System;

namespace VacationHomWork
{
    internal class Program
    {
        static void Main()
        {
            int l = int.Parse(Console.ReadLine());
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            float e = a / (float)c;
            float f = b / (float)d;

            if (Math.Ceiling(e) >= Math.Ceiling(f))
            {
                Console.WriteLine(l - Math.Ceiling(e));
            }
            else if (Math.Ceiling(e) <= Math.Ceiling(f))
            {
                Console.WriteLine(l - Math.Ceiling(f));
            }
        }
    }
}