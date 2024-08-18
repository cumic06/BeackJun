using System;
using System.Text;

namespace Histogram
{
    internal class Program
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();

            int t = int.Parse(Console.ReadLine());

            int a = 0;

            for (int i = 0; i < t; i++)
            {
                a = int.Parse(Console.ReadLine());

                for (int j = 0; j < a; j++)
                {
                    sb.Append("=");
                }
                sb.AppendLine();
            }
            Console.WriteLine(sb.ToString().Trim());
        }
    }
}