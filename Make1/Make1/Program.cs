using System;

namespace Make1
{
    class Program
    {
        static int count = 0;
        static void Main()
        {
            int x = int.Parse(Console.ReadLine());
            int count = 0;

            count += Make1(x);
            Console.WriteLine(count);
        }

        static int Make1(int x)
        {
            if (x % 3 == 0)
            {
                x /= 3;
            }
            else if (x % 2 == 0)
            {
                x /= 2;
                count++;
            }
            else
            {
                x--;
                count++;
            }

            if (x == 1)
            {
                return count;
            }
            else
            {
                return Make1(x);
            }
        }
    }
}