using System;

namespace TestPoint
{
    class Program
    {
        static void Main()
        {
            string[] str = Console.ReadLine().Split();
            string[] str1 = Console.ReadLine().Split();

            int min = int.Parse(str[0]) + int.Parse(str[1]) + int.Parse(str[2]) + int.Parse(str[3]);
            int man = int.Parse(str1[0]) + int.Parse(str1[1]) + int.Parse(str1[2]) + int.Parse(str1[3]);

            if (min > man)
            {
                Console.WriteLine(min);
            }
            else if (man > min)
            {
                Console.WriteLine(man);
            }
            else
            {
                Console.WriteLine(min);
            }
        }
    }
}