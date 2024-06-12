using System;

namespace Multiplication
{
    class Program
    {
        static void Main()
        {
            string astr = Console.ReadLine();
            string bstr = Console.ReadLine();
            int a = int.Parse(astr);
            int b = int.Parse(bstr);

            Console.WriteLine(a * int.Parse(bstr[2].ToString()));
            Console.WriteLine(a * int.Parse(bstr[1].ToString()));
            Console.WriteLine(a * int.Parse(bstr[0].ToString()));

            Console.WriteLine(a * b);
        }
    }
}