using System;
using System.Text;

namespace KingQueenLookBeshopNightPon
{
    class Program
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();
            string[] s = Console.ReadLine().Split();
            int[] str = new int[6] { 1, 1, 2, 2, 2, 8 };

            int b = 0;
            for (int i = 0; i < s.Length; i++)
            {
                int count = 0;
                b = int.Parse(s[i]);

                while (b != str[i])
                {
                    if (b > str[i])
                    {
                        count -= 1;
                    }
                    else if (b < str[i])
                    {
                        count += 1;
                    }
                    b = int.Parse(s[i]) + count;
                }
                sb.Append(count + " ");
            }
            Console.WriteLine(sb.ToString());
        }
    }
}