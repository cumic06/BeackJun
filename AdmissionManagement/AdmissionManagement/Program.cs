using System;
using System.Text;

namespace AdmissionManagement
{
    class Program
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();
            int a = int.Parse(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                sb.AppendLine(Console.ReadLine().ToLower());
            }
            Console.WriteLine(sb.ToString());
        }
    }
}