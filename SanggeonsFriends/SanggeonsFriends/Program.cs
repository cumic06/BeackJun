using System;
using System.Text;

namespace SanggeonsFriends
{
    class Program
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();
            string[] str = new string[2];

            while (true)
            {
                str = Console.ReadLine().Split();
                if (int.Parse(str[0]) == 0) break;
                sb.AppendLine($"{int.Parse(str[0]) + int.Parse(str[1])}");
            }
            Console.WriteLine(sb.ToString().Trim());
        }
    }
}