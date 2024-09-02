using System;

namespace NumberOfVowels
{
    internal class Program
    {
        static void Main()
        {
            string str = Console.ReadLine();
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'a')
                {
                    count++;
                }
                else if (str[i] == 'e')
                {
                    count++;
                }
                else if (str[i] == 'i')
                {
                    count++;
                }
                else if (str[i] == 'o')
                {
                    count++;
                }
                else if (str[i] == 'u')
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}