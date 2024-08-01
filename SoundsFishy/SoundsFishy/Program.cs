using System;

namespace SoundsFishy
{
    class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            if (a > b)
            {
                if (b > c)
                {
                    if (c > d)
                    {
                        Console.WriteLine("Fish Diving");
                    }
                    else
                    {
                        Console.WriteLine("No Fish");
                    }
                }
                else
                {
                    Console.WriteLine("No Fish");
                }
            }
            else if (a < b)
            {
                if (b < c)
                {
                    if (c < d)
                    {
                        Console.WriteLine("Fish Rising");
                    }
                    else
                    {
                        Console.WriteLine("No Fish");
                    }
                }
                else
                {
                    Console.WriteLine("No Fish");
                }
            }
            else
            {
                if (b == c)
                {
                    if (c == d)
                    {
                        Console.WriteLine("Fish At Constant Depth");
                    }
                    else
                    {
                        Console.WriteLine("No Fish");
                    }
                }
                else
                {
                    Console.WriteLine("No Fish");
                }
            }
        }
    }
}