using System;
using System.Text;

namespace After_the_party
{
    internal class Program
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();
            string[] strArray = Console.ReadLine().Split();
            int a = int.Parse(strArray[0]);
            int b = int.Parse(strArray[1]);
            int partyPeople = a * b;

            string[] strArray1 = Console.ReadLine().Split();
            int c = int.Parse(strArray1[0]);
            int d = int.Parse(strArray1[1]);
            int e = int.Parse(strArray1[2]);
            int f = int.Parse(strArray1[3]);
            int g = int.Parse(strArray1[4]);

            sb.AppendLine($"{c - partyPeople} {d - partyPeople} {e - partyPeople} {f - partyPeople} {g - partyPeople}");
            Console.WriteLine(sb.ToString());
        }
    }
}