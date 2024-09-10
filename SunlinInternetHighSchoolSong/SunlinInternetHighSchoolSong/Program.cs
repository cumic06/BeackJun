using System;
using System.Text;

namespace SunlinInternetHighSchoolSong
{
    internal class Program
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();

            int a = int.Parse(Console.ReadLine());
            string str = Console.ReadLine();

            for (int i = str.Length - 5; i < str.Length; i++)
            {
                sb.Append(str[i]);
            }


            Console.WriteLine(sb.ToString());
        }
    }
}