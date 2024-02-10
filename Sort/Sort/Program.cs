using System;
using System.Text;

namespace Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            int[] sortArray = new int[count];

            for (int i = 0; i < count; i++)
            {
                sortArray[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(sortArray);

            StringBuilder stringBuilder = new StringBuilder(string.Join("\n", sortArray));
            Console.WriteLine(stringBuilder);
        }
    }
}
