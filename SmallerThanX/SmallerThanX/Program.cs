using System;
using System.Text;

namespace SmallerThanX
{
    class Program
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();

            string[] str = Console.ReadLine().Split();

            int n = int.Parse(str[0]);
            int x = int.Parse(str[1]);

            int[] aIntArray = new int[n];
            aIntArray = Array.ConvertAll(Console.ReadLine().Split(), (s) => int.Parse(s));

            for (int i = 0; i < aIntArray.Length; i++)
            {
                if (aIntArray[i] < x)
                {
                    sb.Append(aIntArray[i] + " ");
                }
            }
            Console.WriteLine(sb.ToString());
            Console.ReadKey();
        }
    }
}
