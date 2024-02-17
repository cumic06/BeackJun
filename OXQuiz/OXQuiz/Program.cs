using System;

namespace OXQuiz
{
    class Program
    {
        static void Main()
        {
            int testCase = int.Parse(Console.ReadLine());
            int correct = 0;

            for (int i = 0; i < testCase; i++)
            {
                string str = Console.ReadLine();
                correct = CheckSircle(str);
                Console.WriteLine(correct);
            }
        }

        static int CheckSircle(string str)
        {
            int result = 0;
            int continueValue = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].ToString().Equals("O"))
                {
                    result += continueValue + 1;
                    continueValue++;
                }
                else
                {
                    continueValue = 0;
                }
            }
            return result;
        }
    }
}