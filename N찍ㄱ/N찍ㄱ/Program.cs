using System;
using System.Text;

namespace NJJickgi
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            string str = "";
            for (int i = 1; i <= a; i++)
            {
                str += $"{i}\n";
            }
            Console.WriteLine(str);
        }
    }
}
