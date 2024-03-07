using System;
using System.Text;

namespace JustWrite
{
    class Program
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < 100; i++)
            {
                string s = Console.ReadLine().Trim();
                sb.AppendLine(s);
            }

            Console.WriteLine(sb.ToString());
        }
    }
}