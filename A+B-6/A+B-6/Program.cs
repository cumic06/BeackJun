using System;
using System.Text;

namespace A_B_6
{
    class Program
    {
        static void Main()
        {
            int t = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < t; i++)
            {
                string[] str = Console.ReadLine().Split(',');
                int a = int.Parse(str[0]) + int.Parse(str[1]);
                sb.AppendLine(a.ToString());
            }
            Console.WriteLine(sb.ToString());
        }
    }
}