﻿using System;

namespace DogTreats
{
    internal class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            b *= 2;
            c *= 3;
            if (a + b + c < 10)
            {
                Console.WriteLine("sad");
            }
            else
            {
                Console.WriteLine("happy");
            }
        }
    }
}