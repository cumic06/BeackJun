using System;
using System.Text;
using System.Collections.Generic;

namespace Stack
{
    class Program
    {
        static Stack<int> intStack = new Stack<int>();
        static StringBuilder sb = new StringBuilder();

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Stack(Console.ReadLine().Split());
            }
            Console.WriteLine(sb.ToString());
        }

        static void Stack(string[] a)
        {
            string command = a[0];
            int value = 0;
            if (a.Length > 1)
            {
                value = int.Parse(a[1]);
            }
            if (command == "push")
            {
                intStack.Push(value);
            }
            if (command == "top")
            {
                if (intStack.Count == 0)
                {
                    sb.AppendLine("-1");
                }
                else
                {
                    sb.AppendLine($"{intStack.Peek()}");
                }
            }
            if (command == "size")
            {
                sb.AppendLine($"{intStack.Count}");
            }
            if (command == "empty")
            {
                if (intStack.Count == 0)
                {
                    sb.AppendLine("1");
                }
                else
                {
                    sb.AppendLine("0");
                }
            }
            if (command == "pop")
            {
                if (intStack.Count == 0)
                {
                    sb.AppendLine("-1");
                }
                if (intStack.Count >= 1)
                {
                    sb.AppendLine($"{intStack.Pop()}");
                }
            }
        }
    }
}