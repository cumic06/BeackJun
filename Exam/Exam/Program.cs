using System;
using System.Linq;

namespace Exam
{
    internal class Program
    {
        static void Main()
        {
            string[] strArray = Console.ReadLine().Split();
            int a = int.Parse(strArray[0]);
            int b = int.Parse(strArray[1]);
            int c = int.Parse(strArray[2]);

            int[] intArray = new int[3];
            intArray[0] = a;
            intArray[1] = b;
            intArray[2] = c;

            intArray = intArray.OrderByDescending(d => d).ToArray();
            Console.WriteLine(intArray[0] + intArray[1]);
        }
    }
}