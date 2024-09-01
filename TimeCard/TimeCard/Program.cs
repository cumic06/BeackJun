using System;
using System.Text;

namespace TimeCard
{
    class Program
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 3; i++)
            {
                string[] str1 = Console.ReadLine().Split();

                int h1 = int.Parse(str1[0]);
                int m1 = int.Parse(str1[1]);
                int s1 = int.Parse(str1[2]);

                int h2 = int.Parse(str1[3]);
                int m2 = int.Parse(str1[4]);
                int s2 = int.Parse(str1[5]);

                int hour = h2 - h1;
                int min = m2 - m1;
                int sec = s2 - s1;

                if (sec < 0)
                {
                    sec += 60;
                    min--;
                }

                if (min < 0)
                {
                    min += 60;
                    hour--;
                }

                if (hour < 0)
                {
                    hour += 24;
                }

                sb.AppendLine($"{hour} {min} {sec}");
            }
            Console.WriteLine(sb.ToString().Trim());
        }
    }
}