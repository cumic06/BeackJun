using System;

namespace TodayWeather
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = $"{DateTime.Now.ToString("yyy-MM-dd")}";
            Console.WriteLine(result);
        }
    }
}
