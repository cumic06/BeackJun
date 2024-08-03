using System;
using System.Linq;

namespace SanggeunNalds
{
    class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());

            int[] array = new int[3];
            array[0] = a;
            array[1] = b;
            array[2] = c;

            int[] array2 = new int[2];
            array2[0] = d;
            array2[1] = e;

            Console.WriteLine(array.Min() + array2.Min() - 50);
        }
    }
}