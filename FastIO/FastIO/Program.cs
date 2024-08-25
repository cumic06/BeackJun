using System;
using System.IO;
using System.Text;

namespace FastIO
{
    internal class Program
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();

            int numsOfTimes = int.Parse(Console.ReadLine());
            for (int i = 0; i < numsOfTimes; i++)
            {
                using (StringReader reader = new StringReader(Console.ReadLine()))
                {
                    string[] text = reader.ReadLine().Split(' ');
                    int a = int.Parse(text[0]);
                    int b = int.Parse(text[1]);
                    sb.AppendLine((a + b).ToString());
                }
            }
            Console.WriteLine(sb.ToString());

        }
    }
}