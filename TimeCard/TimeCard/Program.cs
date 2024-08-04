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
                    min--;
                    sec = 60 - Math.Abs(s2 - s1);

                    if (min < 0)
                    {
                        hour--;
                        min = 59 - Math.Abs(m2 - m1);
                        if (hour < 0)
                        {
                            hour = 22 - Math.Abs(h2 - h1);
                        }
                    }
                }

                sb.AppendLine($"{hour} {min} {sec}");
            }
            Console.WriteLine(sb.ToString().Trim());
        }
    }
}