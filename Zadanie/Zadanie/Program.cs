using System;

namespace Zadanie
{
    class Program
    {
        static void Main()
        {
            string a = Console.ReadLine();
            string abc = a[2].ToString() + a[1].ToString() + a[0].ToString();
            Console.WriteLine(abc);
        }
    }
}
