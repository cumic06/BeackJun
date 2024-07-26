using System;
using System.Text;

namespace Lunacy
{
    class Program
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();

            float n = 1;

            while (n > 0)
            {
                n = float.Parse(Console.ReadLine());

                if (n < 0) break;

                sb.AppendLine($"Objects weighing {n:0.00} on Earth will weigh {n * 0.167:0.00} on the moon.");
            }
            Console.WriteLine(sb.ToString().Trim());
        }
    }
}