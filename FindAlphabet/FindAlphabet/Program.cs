using System;
using System.Text;

namespace FindAlphabet
{
    class Program
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();
            string s = Console.ReadLine();
            string alphabet = "abcdefghijklmnopqrstuvwxyz";

            for (int i = 0; i < alphabet.Length; i++)
            {
                sb.Append(s.IndexOf(alphabet[i]) + " ");
            }
            Console.WriteLine(sb.ToString());
        }
    }
}