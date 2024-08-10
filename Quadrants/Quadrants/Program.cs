using System;
using System.Text;

namespace Quadrants
{
    internal class Program
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();

            while (true)
            {
                string[] strArray = Console.ReadLine().Split();

                float a = float.Parse(strArray[0]);
                float b = float.Parse(strArray[1]);

                if (a > 0 && b > 0)
                {
                    sb.AppendLine("Q1");
                }
                else if (a < 0 && b > 0)
                {
                    sb.AppendLine("Q2");
                }
                else if (a < 0 && b < 0)
                {
                    sb.AppendLine("Q3");
                }
                else if (a > 0 && b < 0)
                {
                    sb.AppendLine("Q4");
                }
                else if (a == 0 || b == 0)
                {
                    sb.AppendLine("AXIS");
                }
                if (float.Parse(strArray[0]).Equals(0) && float.Parse(strArray[1]).Equals(0)) break;
            }
            Console.WriteLine(sb.ToString().Trim());
        }
    }
}