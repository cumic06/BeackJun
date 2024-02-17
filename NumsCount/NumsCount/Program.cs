using System;
using System.Linq;
using System.Text;

namespace NumsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();

            int muti = a * b * c;
            string mutiString = muti.ToString();

            for (int i = 0; i <= 9; i++)
            {
                int ac = 0;
                if (mutiString.IndexOf(i.ToString()) >= 0)
                {
                    ac = mutiString.Count(f => f.ToString() == i.ToString());
                    sb.Append(ac);
                }
                else
                {
                    sb.Append(0);
                }
                sb.Append("\n");
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
