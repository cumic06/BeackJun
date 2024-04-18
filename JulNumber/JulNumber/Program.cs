using System;
using System.Text;

namespace JulNumber
{
    class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= a; i++)
            {
                sb.AppendLine($"{i}. {Console.ReadLine()}");
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
