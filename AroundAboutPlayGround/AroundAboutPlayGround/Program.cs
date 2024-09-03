using System;

namespace AroundAboutPlayGround
{
    internal class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            float pi = 3.141592f;
            Console.WriteLine((2 * pi * b) + (2 * a));
        }
    }
}