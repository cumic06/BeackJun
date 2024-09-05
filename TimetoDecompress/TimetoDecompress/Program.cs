using System;
using System.Text;

namespace TimetoDecompress
{
    internal class Program
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();
            int t = int.Parse(Console.ReadLine());
            string[] strArray;
            for (int i = 0; i < t; i++)
            {
                strArray = Console.ReadLine().Split();

                for (int j = 0; j < int.Parse(strArray[0]); j++)
                {
                    sb.Append(strArray[1]);
                }
                sb.AppendLine();
            }
            Console.WriteLine(sb.ToString());
        }
    }
}