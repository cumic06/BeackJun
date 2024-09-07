using System;

namespace ThreeInt
{
    internal class Program
    {
        static void Main()
        {
            string[] strArray = Console.ReadLine().Split();
            int a = int.Parse(strArray[0]);
            int b = int.Parse(strArray[1]);
            int c = int.Parse(strArray[2]);

            int count1 = 0;
            int count2 = 0;

            foreach (var item in strArray)
            {
                if (int.Parse(item) == 1)
                {
                    count1++;
                }
                else if (int.Parse(item) == 2)
                {
                    count2++;
                }
            }

            if (count1 > count2)
            {
                Console.WriteLine(1);
            }
            else if (count2 > count1)
            {
                Console.WriteLine(2);
            }
        }
    }
}