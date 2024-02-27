using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AgeSort
{
    class Program
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();
            int n = int.Parse(Console.ReadLine());
            string[] account;

            for (int i = 0; i < n; i++)
            {
                account = Console.ReadLine().Split();
                Array.Sort(account);
                sb.AppendLine(account[0] + " " + account[1]);
            }
            Console.WriteLine(sb.ToString());
        }
    }
}