using System;
using System.Text;

namespace TheSearchPrimeNumber
{
    class Program
    {
        static void Main()
        {
            string[] k = Console.ReadLine().Split();

            int m = int.Parse(k[0]);
            int n = int.Parse(k[1]);
            StringBuilder sb = new StringBuilder();

            bool[] primeArray = new bool[n + 1];

            for (int i = 2; i <= n; i++)
            {
                primeArray[i] = true;
            }

            for (int i = 2; i * i <= n; i++)
            {
                if (primeArray[i])
                {
                    for (int j = i * i; j <= n; j += i)
                    {
                        primeArray[j] = false;
                    }
                }
            }

            for (int i = m; i <= primeArray.Length - 1; i++)
            {
                if (primeArray[i])
                {
                    sb.Append(i + "\n");
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
}