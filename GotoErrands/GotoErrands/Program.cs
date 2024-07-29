using System;

namespace GotoErrands
{
    class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            int min = (a + b + c + d) / 60;
            int sec = (a + b + c + d) % 60;
            Console.WriteLine(min);
            Console.WriteLine(sec);
        }
    }
}