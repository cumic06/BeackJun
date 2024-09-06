using System;

namespace Ah_
{
    internal class Program
    {
        static void Main()
        {
            string ah = Console.ReadLine();
            string ah2 = Console.ReadLine();

            if (ah.Length < ah2.Length)
            {
                Console.WriteLine("no");
            }
            else if (ah.Length >= ah2.Length)
            {
                Console.WriteLine("go");
            }
        }
    }
}