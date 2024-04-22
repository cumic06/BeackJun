using System;
using System.Text;

namespace TopSecret
{
    class Program
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();
            while (true)
            {
                string a = Console.ReadLine();
                if (a == "END") break;

                char[] charA = a.ToCharArray();
                Array.Reverse(charA);

                foreach (var b in charA)
                {
                    sb.Append(b);
                }
                sb.AppendLine();

            }
            Console.WriteLine(sb.ToString());
        }
    }
}