using System;

namespace NumsSum
{
    class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            string str = Console.ReadLine();
            int result = 0;
            for (int i = 0; i < a; i++)
            {
                result += int.Parse(str[i].ToString());
            }
            Console.Write(result + "\n");
        }
    }
}
