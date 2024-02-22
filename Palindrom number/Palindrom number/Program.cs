using System;

namespace Palindrom_number
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                string a = Console.ReadLine();
                if (int.Parse(a[0].ToString()) == 0) break;
                char[] current = a.ToCharArray();
                char[] reverse = a.ToCharArray();
                Array.Reverse(reverse);
                int count = a.Length;
                int currect = 0;

                for (int i = 0; i < a.Length; i++)
                {
                    if (current[i].ToString() == reverse[i].ToString())
                    {
                        currect++;
                    }
                }

                if (currect == count)
                {
                    Console.WriteLine("yes");
                }
                else
                {
                    Console.WriteLine("no");
                }
            }
        }
    }
}