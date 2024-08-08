using System;
using System.Text;

namespace HelloJudge
{
    internal class Program
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();
            int t = int.Parse(Console.ReadLine());

            for (int i = 1; i <= t; i++)
            {
                sb.AppendLine($"Hello World, Judge {i}!");
            }
            Console.WriteLine(sb.ToString().Trim());
        }
    }
}