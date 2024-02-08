using System;

namespace VowelCount
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string str = Console.ReadLine().ToLower();

                int count = 0;
                if (str.Equals("#")) break;
                else
                {
                    for (int i = 0; i < str.Length; i++)
                    {
                        if (str[i].Equals('a') || str[i].Equals('e') || str[i].Equals('i') || str[i].Equals('o') || str[i].Equals('u'))
                        {
                            count++;
                        }
                    }
                    Console.WriteLine(count);
                }
            }
        }
    }
}
