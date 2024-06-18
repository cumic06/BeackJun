using System;

namespace Receipt
{
    class Program
    {
        static void Main()
        {
            int totalMoney = int.Parse(Console.ReadLine());
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] str = Console.ReadLine().Split();

                for (int j = 0; j < int.Parse(str[1]); j++)
                {
                    totalMoney -= int.Parse(str[0]);
                }
            }
            if (totalMoney == 0)
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