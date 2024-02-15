using System;
using System.Text;

namespace GuGuDan
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder stringBuilder = new StringBuilder();

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 9; i++)
            {
                stringBuilder.Append($"{n} * {i} = {n * i}" + "\n");
            }
            Console.WriteLine(stringBuilder);
        }
    }
}