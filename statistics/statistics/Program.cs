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
            //sb.AppendLine(ArithmeticMean().ToString());
            //sb.AppendLine(MedianValue().ToString());
            sb.AppendLine(TheMostCommonValue().ToString());
            //sb.AppendLine(Range().ToString());
            //Console.WriteLine(sb.ToString());
        }

        static int ArithmeticMean()
        {
            int sum = 0;
            for (int i = 0; i < numbersList.Count; i++)
            {
                sum += numbersList[i];
            }
            return (int)Math.Round(sum / (float)numbersList.Count, MidpointRounding.AwayFromZero);
        }
        static int MedianValue()
        {
            numbersList = numbersList.OrderBy((a) => a).ToList();
            return numbersList[numbersList.Count / 2];
        }
        //static int TheMostCommonValue()
        //{
        //    numbersList = numbersList.OrderBy((a) => a).ToList();
        //    int commonValue = ;
        //    for (int i = 0; i < numbersList.Count; i++)
        //    {
        //        if (numbersList[i] == commonValue)
        //        {

        //        }
        //    }
        //}
        static int Range()
        {
            return Math.Abs(numbersList.Max() - numbersList.Min());
        }
    }
}