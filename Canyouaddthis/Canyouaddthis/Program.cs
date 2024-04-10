using System;
using System.Text;

namespace Canyouaddthis
{
    class Program
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();
            int tc = int.Parse(Console.ReadLine());

            for (int i = 0; i < tc; i++)
            {
                string[] sa = Console.ReadLine().Split();
                int a = int.Parse(sa[0]);
                int b = int.Parse(sa[1]);

                sb.AppendLine((a + b).ToString());
            }
            Console.WriteLine(sb.ToString());
        }
    }
}