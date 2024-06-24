using System;

namespace TodayWeatherUTC
{
    class Program
    {
        static void Main()
        {
            DateTime utcNow = DateTime.UtcNow;

            string[] str = utcNow.ToString("yyyy-MM-dd").Split('-');
            Console.WriteLine(str[0]);
            Console.WriteLine(str[1]);
            Console.WriteLine(str[2]);
        }
    }
}