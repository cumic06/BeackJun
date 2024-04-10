using System;
using System.Text;

namespace Rectangles
{
    class Program
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            for (int j = 0; j < a; j++)
            {
                for (int i = 0; i < b; i++)
                {
                    sb.Append("*");
                }
                sb.AppendLine("");
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
