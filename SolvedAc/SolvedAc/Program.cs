using System;

namespace SolvedAc
{
    class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int cut = CuttingAverage(a);
            int[] contributor = new int[a];
            int difficulty = 0;
            if (a != 0)
            {
                for (int i = 0; i < a; i++)
                {
                    int b = int.Parse(Console.ReadLine());
                    contributor[i] = b;
                }

                Array.Sort(contributor);

                for (int i = cut; i < contributor.Length - cut; i++)
                {
                    difficulty += contributor[i];
                }

                difficulty = (int)Math.Round((float)difficulty / (contributor.Length - (cut * 2)), MidpointRounding.AwayFromZero);
            }
            Console.WriteLine(difficulty);
        }

        static int CuttingAverage(int a)
        {
            return (int)Math.Round((float)a * 0.15f, MidpointRounding.AwayFromZero);
        }
    }
}