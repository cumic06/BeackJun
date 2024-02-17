using System;
using System.Text;

namespace StarJJick2
{
    class Program
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();
            int a = int.Parse(Console.ReadLine());
            for (int i = a - 1; i >= 0; i--)
            {
                for (int j = i; j > 0; j--)
                {
                    sb.Append(" ");
                }
                for (int j = a; j > i; j--)
                {
                    sb.Append("*");
                }
                sb.Append("\n");
            }
            Console.Write(sb.ToString());
        }
    }
}