using System;
using System.Text;

namespace Schronisko
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

                float people = a * b * 0.5f;
                if (people >= 1)
                {
                    sb.AppendLine($"{Math.Truncate(people)}");
                }
                else
                {
                    sb.AppendLine($"{0}");
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}