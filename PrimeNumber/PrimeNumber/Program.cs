using System;
using System.Text;

namespace PrimeNumber
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string[] numbers = Console.ReadLine().Split();
            int[] numbersInt = new int[n];
            int primeNum = 0;
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbersInt[i] = int.Parse(numbers[i]);
            }

            foreach (var number in numbersInt)
            {
                for (int i = 1; i < number; i++)
                {
                    if (number == 2 || number == 3 || number == 5 || number == 7)
                    {
                        primeNum++;
                        break;
                    }

                    if (i > 2 && number % i == 0 || number == 1 || number % 2 == 0) break;
                    else if (i == number - 1)
                    {
                        primeNum++;
                        break;
                    }
                }
            }
            sb.Append(primeNum);
            Console.WriteLine(sb.ToString());
        }
    }
}