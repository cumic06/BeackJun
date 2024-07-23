using System;
using System.Text;

namespace NoBrainer
{
    class Program
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();

            int t = int.Parse(Console.ReadLine());

            string[] str = new string[] { };

            for (int i = 0; i < t; i++)
            {
                str = Console.ReadLine().Split();

                int a = int.Parse(str[0]);
                int b = int.Parse(str[1]);

                if (a >= b)
                {
                    sb.AppendLine("MMM BRAINS");
                }
                else
                {
                    sb.AppendLine("NO BRAINS");
                }
            }
            Console.WriteLine(sb.ToString().Trim());
        }
    }
}