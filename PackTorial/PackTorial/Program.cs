using System;

namespace PackTorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            if (a >= 0 && a <= 12)
            {
                int b = 1;
                for (int i = 1; i <= a; i++)
                {
                    b = b * i;
                }
                Console.WriteLine(b);
            }
        }
    }
}
