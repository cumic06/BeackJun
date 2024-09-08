using System;

namespace ukje
{
    internal class Program
    {
        static void Main()
        {
            string[] strArray = Console.ReadLine().Split();
            int a = int.Parse(strArray[0]);
            int b = int.Parse(strArray[1]);

            double m = (b - a) / (float)400;

            double percent = 1 / (1 + Math.Pow(10, m));

            Console.WriteLine(percent);
        }
    }
}