﻿using System;

namespace Sum
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i <= n; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);
        }
    }
}