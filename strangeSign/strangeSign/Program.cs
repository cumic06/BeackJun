﻿using System;

namespace strangeSign
{
    class Program
    {
        static void Main()
        {
            string[] str = Console.ReadLine().Split();
            long a = long.Parse(str[0]);
            long b = long.Parse(str[1]);
            Console.WriteLine((a + b) * (a - b));
        }
    }
}