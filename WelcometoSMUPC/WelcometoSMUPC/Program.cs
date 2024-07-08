using System;

namespace WelcometoSMUPC
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string str = "WelcomeToSMUPC";

            int index = (n - 1) % 14;
            Console.WriteLine(str[index]);
        }
    }
}