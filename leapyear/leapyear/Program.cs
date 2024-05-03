using System;

namespace leapyear
{
    class Program
    {
        static void Main()
        {
            string a = Console.ReadLine();
            int b = int.Parse(a);

            if (b % 4 == 0 && b % 100 != 0 || b % 400 == 0)
            {
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
