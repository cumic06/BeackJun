using System;
using System.Text;

namespace CodingisP.E
{
    class Program
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();

            int n = int.Parse(Console.ReadLine());
            int t = n / 4;
            for (int i = 0; i < t; i++)
            {
                sb.Append("long ");
            }
            sb.Append("int");
            Console.WriteLine(sb.ToString());
        }
    }
}