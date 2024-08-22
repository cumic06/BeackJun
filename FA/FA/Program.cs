using System;

namespace FA
{
    internal class Program
    {
        static void Main()
        {
            string x = Console.ReadLine();

            int a = int.Parse(x[0].ToString());
            int b = int.Parse(x[x.Length - 1].ToString());

            string c = FA(a, b);

            while (true)
            {
                if (c == FA(a, b))
                {
                    Console.WriteLine("FA");
                    break;
                }
                else
                {
                    Console.WriteLine("NFA");
                    break;
                }
            }
        }

        static string FA(int a, int b)
        {
            return (a * b).ToString();
        }
    }
}