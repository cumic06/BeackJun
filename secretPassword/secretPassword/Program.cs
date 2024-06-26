using System;
using System.Text;

namespace secretPassword
{
    class Program
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();

            int t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                string str = Console.ReadLine();
                if (str.Length >= 6 && str.Length <= 9)
                {
                    sb.AppendLine("yes");
                }
                else
                {
                    sb.AppendLine("no");
                }
            }
            Console.WriteLine(sb.ToString().Trim());
        }
    }
}