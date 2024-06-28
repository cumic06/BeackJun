using System;
using System.Text;

namespace Copier
{
    class Program
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();

            int t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                int n = int.Parse(Console.ReadLine());
                sb.AppendLine($"{n} {n}");
            }
            Console.WriteLine(sb.ToString());
        }
    }
}