using System;

namespace A_B_4
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                string s = Console.ReadLine();
                if (s == null) break;
                string[] str = s.Split();//Split으로 나누면 빈배열 반환하기 때문에 null 아님
                int a = int.Parse(str[0]);
                int b = int.Parse(str[1]);
                if (a >= 10 && b >= 10) return;
                Console.WriteLine(a + b);
            }
        }
    }
}
