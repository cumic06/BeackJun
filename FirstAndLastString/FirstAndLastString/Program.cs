using System;

namespace FirstAndLastString
{
    class Program
    {
        static void Main()
        {
            int t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                string a = Console.ReadLine();
                Console.WriteLine(a[0] + a[a.Length - 1].ToString());
            }
        }
    }
}