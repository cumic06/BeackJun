using System;

namespace _10BuJe
{
    internal class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());

            string[] strArray = Console.ReadLine().Split();

            int[] intArray = new int[5] { int.Parse(strArray[0]), int.Parse(strArray[1]), int.Parse(strArray[2]), int.Parse(strArray[3]), int.Parse(strArray[4]) };

            int count = 0;

            for (int i = 0; i < intArray.Length; i++)
            {
                if (intArray[i].Equals(a))
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}