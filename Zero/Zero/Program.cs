using System;
using System.Collections.Generic;
using System.Linq;

namespace Zero
{
    class Program
    {
        static void Main()
        {
            int k = int.Parse(Console.ReadLine());
            Stack<int> aStack = new Stack<int>();

            for (int i = 0; i < k; i++)
            {
                int n = int.Parse(Console.ReadLine());
                if (n.Equals(0))
                {
                    aStack.Pop();
                }
                else
                {
                    aStack.Push(n);
                }
            }

            Console.WriteLine(aStack.Sum());
        }
    }
}
