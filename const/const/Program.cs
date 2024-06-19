using System;

namespace Const
{
    class Program
    {
        static void Main()
        {
            string[] str = Console.ReadLine().Split();

            if (Rev(str[0]) > Rev(str[1]))
            {
                Console.WriteLine(Rev(str[0]));
            }
            else
            {
                Console.WriteLine(Rev(str[1]));
            }
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