using System;
using System.Text;

namespace TheSearchPrimeNumber
{
    class Program
    {
        static void Main()
        {
            string[] k = Console.ReadLine().Split();
            int m = int.Parse(k[0]);
            int n = int.Parse(k[1]);
            StringBuilder sb = new StringBuilder();

            for (int i = m; i <= n; i++)
            {
                if (i == 2 || i == 3 || i == 5 || i == 7)
                {
                    sb.AppendLine(i.ToString());
                }

                if (i > 2 && i % 2 != 0 && i % 3 != 0 && i % 5 != 0 && i % 7 != 0)
                {
                    sb.AppendLine(i.ToString());
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
