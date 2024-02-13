using System;

namespace ReverseSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split();
            string X = str[0];
            string Y = str[1];

            int reverseSum = Rev(X) + Rev(Y);
            Console.WriteLine(Rev(reverseSum.ToString()));
            Console.ReadKey();
        }

        static int Rev(string value)
        {
            char[] abc = value.ToCharArray();

            Array.Reverse(abc);


            string resultString = new string(abc);
            return int.Parse(resultString);
        }
    }
}