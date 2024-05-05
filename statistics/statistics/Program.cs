using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace statistics
{
    class Program
    {
        static List<int> numbersList = new List<int>();
        static StringBuilder sb = new StringBuilder();

        static void Main()
        {
            int t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                int a = int.Parse(Console.ReadLine());
                numbersList.Add(a);
            }
            Console.WriteLine(ArithmeticMean());
            Console.WriteLine(MedianValue());
        }

        static int ArithmeticMean()//산술평균
        {
            int result = 0;
            for (int i = 0; i < numbersList.Count; i++)
            {
                result += numbersList[i];
            }
            return (int)Math.Round(result / (float)numbersList.Count, MidpointRounding.AwayFromZero);
        }

        static int MedianValue()//중앙값
        {
            numbersList = numbersList.OrderBy(a => a).ToList();
            return numbersList[numbersList.Count / 2];
        }

        static int LotOfValue()
        {

        }
    }
}