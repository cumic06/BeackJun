using System;

namespace VerificationNum
{
    class Program
    {
        static void Main()
        {
            string[] str = Console.ReadLine().Split();
            int a = int.Parse(str[0]) * int.Parse(str[0]);
            int b = int.Parse(str[1]) * int.Parse(str[1]);
            int c = int.Parse(str[2]) * int.Parse(str[2]);
            int d = int.Parse(str[3]) * int.Parse(str[3]);
            int e = int.Parse(str[4]) * int.Parse(str[4]);
            int sum = a + b + c + d + e;
            int result = sum % 10;
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
