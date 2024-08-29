using System;
using System.Linq;

namespace _3Dice
{
    internal class Program
    {
        static void Main()
        {
            string[] strArray = Console.ReadLine().Split();

            int[] intArray = new int[strArray.Length];
            int a = int.Parse(strArray[0]);
            int b = int.Parse(strArray[1]);
            int c = int.Parse(strArray[2]);

            intArray[0] = a;
            intArray[1] = b;
            intArray[2] = c;
            int result = 0;

            if (a == b)
            {
                if (a == c)
                {
                    result = 10000 + (a * 1000);
                }
                else
                {
                    result = 1000 + (a * 100);
                }
            }
            else
            {
                if (a == c)
                {
                    result = 1000 + (a * 100);
                }
                else
                {
                    result = intArray.Max() * 100;
                }

                if (b == c)
                {
                    result = 1000 + (b * 100);
                }
            }
            Console.WriteLine(result);
        }
    }
}