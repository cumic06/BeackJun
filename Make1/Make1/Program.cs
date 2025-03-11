using System;

namespace Make1
{
    class Program
    {
        static int count = 0;

        static void Main()
        {
            int x = int.Parse(Console.ReadLine());
            count += Make1(x);

            Console.WriteLine($"totalCount {count}");
        }

        static int[] memo = new int[9999];

        static int Make1(int value)
        {
            if (value == 1) return count;
            Console.WriteLine($"start Value{value}");

            if (value % 3 != 0)
            {
                Console.WriteLine("one");
                value -= 1;
                count++;
            }

            if (value % 3 == 0)
            {
                Console.WriteLine("three");
                value /= 3;
                count++;
            }
            else if (value % 2 == 0)
            {
                Console.WriteLine("two");
                value /= 2;
                count++;
            }

            Console.WriteLine($"count {count}");

            if (value == 1)
            {
                return count;
            }
            else
            {
                return Make1(value);
            }
        }
    }
}