using System;

namespace Equality
{
    internal class Program
    {
        static void Main()
        {
            string[] strArray = Console.ReadLine().Trim().Split();

            int a = 0;
            int b = 0;
            int c = 0;

            a = int.Parse(strArray[0]);
            b = int.Parse(strArray[2]);
            c = int.Parse(strArray[4]);

            if ((a + b).Equals(c))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}