using System;
using System.Collections.Generic;

namespace PercentSign
{
    class Program
    {
        static void Main()
        {
            HashSet<int> aHash = new HashSet<int>();

            for (int i = 0; i < 10; i++)
            {
                aHash.Add(int.Parse(Console.ReadLine()) % 42);
            }

            Console.WriteLine(aHash.Count);
        }
    }
}
