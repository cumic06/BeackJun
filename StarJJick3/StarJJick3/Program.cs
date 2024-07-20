using System;
using System.Text;

namespace StarJJick3
{
    class Program
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();
            int a = int.Parse(Console.ReadLine());
            for (int i = a - 1; i >= 0; i--)
            {
                for (int j = i; j >= 0; j--)
                {
                    sb.Append("*");
                }
                sb.Append("\n");
            }
            Console.Write(sb.ToString());
        }
    }
}