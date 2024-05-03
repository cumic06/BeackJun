using System;
using System.Text;

namespace AlarmClock
{
    class Program
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();

            string[] strArray = Console.ReadLine().Split();
            int h = int.Parse(strArray[0]);
            int m = int.Parse(strArray[1]);

            m -= 45;

            if (m < 0)
            {
                h--;
                if (h < 0)
                {
                    h += 24;
                }

                m = 60 - Math.Abs(m);
                sb.Append($"{h} {m}");
            }
            else
            {
                sb.Append($"{h} {m}");
            }
            Console.WriteLine(sb.ToString());
        }
    }
}