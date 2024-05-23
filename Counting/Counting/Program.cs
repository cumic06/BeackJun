using System;
using System.Collections.Generic;

namespace Counting
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<int> m = new List<int>();

            string[] na = Console.ReadLine().Trim().Split();
            for (int i = 0; i < na.Length; i++)
            {
                m.Add(int.Parse(na[i]));
            }
            int v = int.Parse(Console.ReadLine());

            m.RemoveAll((a) => a != v);

            Console.WriteLine(m.Count);
        }
    }
}
