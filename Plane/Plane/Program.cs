using System;

namespace Plane
{
    internal class Program
    {
        static void Main()
        {
            string[] strArray = Console.ReadLine().Split();
            int a = int.Parse(strArray[0]);
            int b = int.Parse(strArray[1]);
            int c = int.Parse(strArray[2]);
            int d = int.Parse(strArray[3]);

            Console.WriteLine((a * b) + (c * d));
        }
    }
}