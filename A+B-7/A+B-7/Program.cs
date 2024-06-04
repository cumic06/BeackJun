using System;
using System.Text;

namespace A_B_7
{
    class Program
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();

            int t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                string[] str = Console.ReadLine().Split();

                int a = int.Parse(str[0]);
                int b = int.Parse(str[1]);
                sb.AppendLine($"Case #{i + 1}: {a + b}");
            }
            Console.WriteLine(sb.ToString());
        }
    }
}