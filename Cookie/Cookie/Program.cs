﻿using System;

namespace Cookie
{
    internal class Program
    {
        static void Main()
        {
            string[] strArray = Console.ReadLine().Split();

            int a = int.Parse(strArray[0]);
            int b = int.Parse(strArray[1]);
            int c = int.Parse(strArray[2]);

            if (a * b - c >= 0)
            {
                Console.WriteLine(a * b - c);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}