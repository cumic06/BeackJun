using System;
using System.Text;

namespace Quadrilateral
{
    internal class Program
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();

            int t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                string[] strArray = Console.ReadLine().Split();

                int a = int.Parse(strArray[0]);
                int b = int.Parse(strArray[1]);

                for (int k = 0; k < b; k++)
                {
                    for (int j = 0; j < a; j++)
                    {
                        sb.Append("X");
                    }
                    sb.AppendLine();
                }
                sb.AppendLine();
            }
            Console.WriteLine(sb.ToString().Trim());
        }
    }
}