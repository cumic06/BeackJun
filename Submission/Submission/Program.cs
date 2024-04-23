using System;
using System.Collections.Generic;
using System.Text;

namespace Submission
{
    class Program
    {
        static void Main()
        {
            List<int> student = new List<int>();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < 28; i++)
            {
                int a = int.Parse(Console.ReadLine());
                student.Add(a);
            }

            for (int i = 1; i <= 30; i++)
            {
                if (!student.Contains(i))
                {
                    sb.AppendLine(i.ToString());
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
