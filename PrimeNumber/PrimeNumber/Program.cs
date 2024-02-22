using System;

namespace PrimeNumber
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string[] pn = Console.ReadLine().Split();
            int[] pnInt = Array.ConvertAll(pn, s => int.Parse(s));
            int primeNumCount = 0;
            int[] tenX = new int[10] { 100, 200, 300, 400, 500, 600, 700, 800, 900, 1000 };

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < tenX.Length - 1; j++)
                {
                    if (pnInt[i] % 2 != 0 && pnInt[i] != 1 && pnInt[i] != tenX[j])
                    {
                        primeNumCount++;
                    }
                    else if (pnInt[i] % 3 != 0 && pnInt[i] != 1 && pnInt[i] != tenX[j])
                    {
                        primeNumCount++;
                    }
                    else if (pnInt[i] % 5 != 0 && pnInt[i] != 1 && pnInt[i] != tenX[j])
                    {
                        primeNumCount++;
                    }
                    else if (pnInt[i] % 7 != 0 && pnInt[i] != 1 && pnInt[i] != tenX[j])
                    {
                        primeNumCount++;
                    }
                }
            }
            Console.WriteLine(primeNumCount);
        }
    }
}