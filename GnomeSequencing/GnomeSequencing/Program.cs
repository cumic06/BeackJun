using System;
using System.Text;

namespace GnomeSequencing
{
    class Program
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();
            int t = int.Parse(Console.ReadLine());

            sb.AppendLine("Gnomes:");
            for (int i = 0; i < t; i++)
            {
                string[] str = Console.ReadLine().Split();

                if (int.Parse(str[0]) > int.Parse(str[1]))
                {
                    if (int.Parse(str[1]) > int.Parse(str[2]))
                    {
                        sb.AppendLine("Ordered");
                    }
                    else if (int.Parse(str[1]) < int.Parse(str[2]))
                    {
                        sb.AppendLine("Unordered");
                    }
                }
                else if (int.Parse(str[0]) < int.Parse(str[1]))
                {
                    if (int.Parse(str[1]) < int.Parse(str[2]))
                    {
                        sb.AppendLine("Ordered");
                    }
                    else if (int.Parse(str[1]) > int.Parse(str[2]))
                    {
                        sb.AppendLine("Unordered");
                    }
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}