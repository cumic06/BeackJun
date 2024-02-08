using System;

namespace GGMAJungMin
{
    class Program
    {
        static void Main(string[] args)
        {   
            string[] str = Console.ReadLine().Split();
            long a = long.Parse(str[0]) + long.Parse(str[1]) + long.Parse(str[2]);

            Console.WriteLine(a);
        }
    }
}
