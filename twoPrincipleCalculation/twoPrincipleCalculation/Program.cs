using System;

namespace twoPrincipleCalculation
{
    internal class Program
    {
        static void Main()
        {
            string[] strArray = Console.ReadLine().Split();

            decimal[] intArray = new decimal[3];

            intArray[0] = decimal.Parse(strArray[0]);
            intArray[1] = decimal.Parse(strArray[1]);
            intArray[2] = decimal.Parse(strArray[2]);

            decimal a = intArray[0] * intArray[1] / intArray[2];
            decimal b = intArray[0] / intArray[1] * intArray[2];

            if (a > b)
            {
                Console.WriteLine($"{(int)a}");
            }
            else if (b > a)
            {
                Console.WriteLine($"{(int)b}");
            }
        }
    }
}