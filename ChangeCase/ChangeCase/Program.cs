using System;
using System.Linq;

namespace ChangeCase
{
    class Program
    {
        static void Main()
        {
            string a = Console.ReadLine();
            char[] b = a.Select(str => char.IsUpper(str) ? char.ToLower(str) : char.ToUpper(str)).ToArray();
            Console.WriteLine(b);
        }
    }
}