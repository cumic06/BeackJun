using System;
using System.Linq;

namespace SubjectSelect
{
    internal class Program
    {
        static void Main()
        {
            int[] intArray = new int[4];
            int[] intArray2 = new int[2];

            for (int i = 0; i < 4; i++)
            {
                int a = int.Parse(Console.ReadLine());

                intArray[i] = a;
            }
            for (int i = 0; i < 2; i++)
            {
                int a = int.Parse(Console.ReadLine());
                intArray2[i] = a;
            }
            intArray = intArray.OrderByDescending(a => a).ToArray();
            intArray2 = intArray2.OrderByDescending(a => a).ToArray();
            Console.WriteLine(intArray[0] + intArray[1] + intArray[2] + intArray2[0]);

        }
    }
}