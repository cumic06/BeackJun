using System;
using System.Text;

namespace GiJJick
{
    class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            for (int i = a; i >= 1; i--)
            {
                sb.AppendLine(i.ToString());
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
