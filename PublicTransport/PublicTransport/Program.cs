using System;

namespace PublicTransport
{
    class Program
    {
        static void Main()
        {
            string[] str = Console.ReadLine().Split();
            int n = int.Parse(str[0]);//subway
            int a = int.Parse(str[1]);//bus
            int b = int.Parse(str[2]);//subway

            if (a < b)
            {
                Console.WriteLine("Bus");
            }
            else if (a > b)
            {
                Console.WriteLine("Subway");
            }
            else
            {
                Console.WriteLine("Anything");
            }
        }
    }
}