using System;

namespace Make1
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = int.Parse(Console.ReadLine());
            int count = 0;
            if (X > 0)
            {
                while (X > 2)
                {
                    if (X % 3 == 0)
                    {
                        X /= 3;
                        count++;
                        Console.WriteLine("%3 " + X);
                    }
                    else if (X % 2 == 0)
                    {
                        X /= 2;
                        count++;
                        Console.WriteLine("%2 " + X);
                    }
                    else
                    {
                        Min(ref X, ref count);
                    }
                }
                Min(ref X, ref count);
                Console.WriteLine("result " + count);
                Console.ReadKey();
            }
        }

        static void Min(ref int X, ref int count)
        {
            if (X > 1)
            {
                X--;
                count++;
                Console.WriteLine("Min" + X);
            }
        }
    }
}
