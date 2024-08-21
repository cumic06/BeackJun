using System;

namespace chickenTwo
{
    internal class Program
    {
        static void Main()
        {
            string[] strArray = Console.ReadLine().Split();
            int c = int.Parse(Console.ReadLine());

            int a = int.Parse(strArray[0]);
            int b = int.Parse(strArray[1]);

            if (a + b < c * 2)
            {
                Console.WriteLine(a + b);
            }
            else if (a + b >= c * 2)
            {
                Console.WriteLine(a + b - c * 2);
            }
        }
    }
}