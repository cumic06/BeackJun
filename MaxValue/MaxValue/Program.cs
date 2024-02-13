using System;
using System.Collections.Generic;
using System.Linq;

namespace MaxValue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> b = new List<int>();

            for (int i = 0; i < 9; i++)
            {
                b.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine(b.Max());
            Console.WriteLine(b.IndexOf(b.Max()) + 1);
        }
    }
}
