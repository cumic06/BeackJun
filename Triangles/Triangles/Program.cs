using System;
using System.Text;

namespace Triangles
{
    class Program
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();
            int a = 1;

            while (a != 0)
            {
                a = int.Parse(Console.ReadLine());

                for (int i = 1; i <= a; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        sb.Append("*");
                    }
                    sb.AppendLine();
                }
            }
            Console.WriteLine(sb.ToString().Trim());
        }
    }
}