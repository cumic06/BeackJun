using System;
using System.Text;

namespace A_B_2
{
    class Program
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            sb.Append(a + b);
            Console.WriteLine(sb.ToString());
        }
    }
}
