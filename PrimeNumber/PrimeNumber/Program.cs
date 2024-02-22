using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string[] pn = Console.ReadLine().Split();
            int[] pnInt = Array.ConvertAll(pn, s => int.Parse(s));

            for (int i = 0; i < n; i++)
            {
                if (pnInt[i] % 2 != 0)
                {

                }
                if (pnInt[i] % 3 != 0)
                {

                }
                if (pnInt[i] % 5 != 0)
                {

                }
                if (pnInt[i] % 7 != 0)
                {

                }
            }
        }
    }
}