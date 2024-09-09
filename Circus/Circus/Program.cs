using System;

namespace Circus
{
    internal class Program
    {
        static void Main()
        {
            long a = long.Parse(Console.ReadLine());

            Console.WriteLine(Math.Sqrt(a * Math.PI) * 2);
        }
    }
}