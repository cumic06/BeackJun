using System;
using System.Linq;
using System.Text;

namespace RiceSack
{
    internal class Program
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();
            int t = int.Parse(Console.ReadLine());
            int[] intArray = new int[5];

            for (int i = 1; i <= t; i++)
            {
                string[] strArray = Console.ReadLine().Split();

                intArray[0] = int.Parse(strArray[0]);
                intArray[1] = int.Parse(strArray[1]);
                intArray[2] = int.Parse(strArray[2]);
                intArray[3] = int.Parse(strArray[3]);
                intArray[4] = int.Parse(strArray[4]);

                sb.AppendLine($"Case #{i}: {intArray.Max()}");
            }
            Console.WriteLine(sb.ToString().Trim());
        }
    }
}