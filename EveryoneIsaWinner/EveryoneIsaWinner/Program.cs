using System;

namespace EveryoneIsaWinner
{
    class Program
    {
        static void Main()
        {
            string[] str = Console.ReadLine().Split();
            int a = int.Parse(str[0]);
            int b = int.Parse(str[1]);

            if (a % b == 0)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}