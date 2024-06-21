using System;

namespace DariusNoHanta
{
    class Program
    {
        static void Main()
        {
            string[] str = Console.ReadLine().Split('/');

            if (int.Parse(str[1]) == 0)
            {
                Console.WriteLine("hasu");
                return;
            }

            if (int.Parse(str[1]) <= int.Parse(str[0]) + int.Parse(str[2]))
            {
                Console.WriteLine("gosu");
            }
            else if (int.Parse(str[1]) > int.Parse(str[0]) + int.Parse(str[2]))
            {
                Console.WriteLine("hasu");
            }
        }
    }
}