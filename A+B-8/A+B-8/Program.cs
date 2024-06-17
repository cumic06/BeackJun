using System;
using System.Text;

namespace A_B_8
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
                sb.AppendLine($"Case #{i + 1}: {int.Parse(str[0])} + {int.Parse(str[1])} = {int.Parse(str[0]) + int.Parse(str[1])}");
            }
            Console.WriteLine(sb.ToString());
        }
    }
}