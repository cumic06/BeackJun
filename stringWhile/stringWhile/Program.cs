using System;

namespace stringWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = "";
            int t = int.Parse(Console.ReadLine());
            if (t > 1001) return;
            for (int i = 0; i < t; i++)
            {
                string[] rs = Console.ReadLine().Split();
                int r = int.Parse(rs[0]);
                string s = rs[1];

                if (s.Length > 20) return;
                if (s.Length <= 0) return;

                for (int l = 0; l < s.Length; l++)
                {
                    for (int j = 0; j < r; j++)
                    {
                        result += s[l];
                    }
                }

                Console.WriteLine(result);
                result = "";
            }
        }
    }
}