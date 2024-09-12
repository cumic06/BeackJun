using System;

namespace WhatIsNewbieIsStandard
{
    internal class Program
    {
        static void Main()
        {
            string[] strArray = Console.ReadLine().Split();

            int n = int.Parse(strArray[0]);
            int m = int.Parse(strArray[1]);

            if (m <= n && m <= 2)
            {
                Console.WriteLine("NEWBIE!");
            }
            else if (m <= n && m >= 3)
            {
                Console.WriteLine("OLDBIE!");
            }
            else
            {
                Console.WriteLine("TLE!");
            }
        }
    }
}