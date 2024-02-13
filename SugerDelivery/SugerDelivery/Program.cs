using System;

namespace SugerDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int suger = int.Parse(Console.ReadLine());
            int bongji1 = 0;
            int bongji2 = 0;
            while (suger > 0)
            {
                if (suger % 5 == 0)
                {
                    bongji1 = suger / 5;
                    break;
                }

                suger -= 3;
                bongji2++;
            }

            if (suger >= 0)
            {
                Console.WriteLine(bongji1 + bongji2);
            }
            else
            {
                Console.WriteLine(-1);
            }
        }
    }
}
