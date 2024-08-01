using System;

namespace BodyMassIndex
{
    class Program
    {
        static void Main()
        {
            float weight = float.Parse(Console.ReadLine());
            float height = float.Parse(Console.ReadLine());

            float bmi = weight / (height * height);
            if (bmi > 25)
            {
                Console.WriteLine("Overweight");
            }
            else if (bmi > 18.5f && bmi < 25.0f)
            {
                Console.WriteLine("Normal weight");
            }
            else if (bmi < 18.5f)
            {
                Console.WriteLine("Underweight");
            }
        }
    }
}