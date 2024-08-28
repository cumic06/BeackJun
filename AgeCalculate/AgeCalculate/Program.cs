using System;
using System.Text;

namespace AgeCalculate
{
    internal class Program
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();

            string[] stringArray1 = Console.ReadLine().Split();
            string[] stringArray2 = Console.ReadLine().Split();

            int a = int.Parse(stringArray1[0]);
            int b = int.Parse(stringArray1[1]);
            int c = int.Parse(stringArray1[2]);

            int d = int.Parse(stringArray2[0]);
            int e = int.Parse(stringArray2[1]);
            int f = int.Parse(stringArray2[2]);

            int result = 0;

            if (e > b)
            {
                result = d - a;
            }
            else if (e == b && f >= c)
            {
                result = d - a;
            }
            else
            {
                result = d - a - 1;
            }

            sb.AppendLine(result.ToString());
            sb.AppendLine((d - a + 1).ToString());
            sb.AppendLine((d - a).ToString());
            Console.WriteLine(sb.ToString().Trim());
        }
    }
}