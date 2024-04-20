using System;

namespace NextLine
{
    class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = b - a;
            int d = b + c;

            Console.WriteLine(d);
        }
    }
}
