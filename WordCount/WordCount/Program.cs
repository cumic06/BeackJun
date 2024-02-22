using System;

namespace WordCount
{
    class Program
    {
        static void Main()
        {
            string[] str = Console.ReadLine().Trim().Split();

            int count = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == "")
                {
                    count++;
                }
            }
            Console.WriteLine(str.Length - count);
        }
    }
}