using System;

namespace WordCount
{
    class Program
    {
        static void Main()
        {
            string[] str = Console.ReadLine().Trim().Split();
            int count = str.Length;
            Console.WriteLine(count);
        }
    }
}
