using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundsFishy
{
    class Program
    {
        static void Main()
        {
            List<int> lists = new List<int>();

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            lists.Add(a);
            lists.Add(b);
            lists.Add(c);
            lists.Add(d);

            if (lists.Equals(lists.OrderBy(e => e).ToList()))
            {
                Console.WriteLine("Fish Rising");
            }
            else if (lists.Equals(lists.OrderByDescending(e => e)))
            {
                Console.WriteLine("Fish Diving");
            }
            else
            {
                Console.WriteLine("No Fish");
            }
        }
    }
}