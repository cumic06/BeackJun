using System;
using System.Text;

namespace FillTheRowboats_
{
    class Program
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (i % 6 == 0)
                {
                    sb.Append($"{i} ");
                    if (i == n) break;
                    sb.Append("Go! ");
                }
                else
                {
                    sb.Append($"{i} ");
                }
            }
            sb.Append("Go!");
            Console.WriteLine(sb.ToString());
        }
    }
}