using System;

namespace IdentifyingTea
{
    internal class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());

            string[] strArray = Console.ReadLine().Split();

            int count = 0;

            for (int i = 0; i < strArray.Length; i++)
            {
                if (int.Parse(strArray[i]) == a)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}