using System;
using System.Text;

namespace ASCIICode
{
    class Program
    {
        static void Main()
        {
            StringBuilder s = new StringBuilder();
            int a = Console.Read();
            string v = a + "\n";
            s.Append(v);
            Console.Write(s.ToString());
        }
    }
}
