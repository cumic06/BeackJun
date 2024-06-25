using System;
using System.Text;

namespace rugbyClub
{
    class Program
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();

            while (true)
            {
                string str = Console.ReadLine();
                if (str.Contains("#")) break;

                string[] member = str.Split();

                if (int.Parse(member[1]) <= 17)
                {
                    if (int.Parse(member[2]) >= 80)
                    {
                        sb.AppendLine($"{member[0]} Senior");
                    }
                    else
                    {
                        sb.AppendLine($"{member[0]} Junior");
                    }
                }
                else
                {
                    sb.AppendLine($"{member[0]} Senior");
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}