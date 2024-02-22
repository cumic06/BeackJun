using System;
using System.Text;

namespace NumOrderBy3
{
    class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int[] b = new int[a];
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < a; i++)
            {
                b[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(b);
            for (int i = 0; i < a; i++)
            {
                sb.Append(b[i] + "\n");
            }
            Console.WriteLine(sb);
        }
    }
}
