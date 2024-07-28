using System;

namespace SpeedFinesAreNotFine_
{
    class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (b > a)
            {
                if (b - a <= 20)
                {
                    Console.WriteLine($"You are speeding and your fine is ${100}.");
                }
                else if (b - a <= 30)
                {
                    Console.WriteLine($"You are speeding and your fine is ${270}.");
                }
                else if (b - a >= 31)
                {
                    Console.WriteLine($"You are speeding and your fine is ${500}.");
                }
            }
            else
            {
                Console.WriteLine($"Congratulations, you are within the speed limit!");
            }
        }
    }
}