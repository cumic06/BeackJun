using System;
using System.Linq;
using System.Text;

namespace SortingTheThreeNumber
{
    class Program
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();

            string[] str = Console.ReadLine().Split();

            str = str.OrderBy(a => int.Parse(a)).ToArray();

            sb.Append($"{int.Parse(str[0])} {int.Parse(str[1])} {int.Parse(str[2])}");

            Console.WriteLine(sb.ToString());
        }
    }
}