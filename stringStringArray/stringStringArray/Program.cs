using System;

namespace stringStringArray
{
    class Program
    {

        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int index = int.Parse(Console.ReadLine()) - 1;

            Console.WriteLine(str[index].ToString());
        }
    }
}
