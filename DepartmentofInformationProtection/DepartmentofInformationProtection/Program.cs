using System;

namespace DepartmentofInformationProtection
{
    class Program
    {
        static void Main()
        {
            string str = Console.ReadLine();

            switch (str)
            {
                case "M":
                    Console.WriteLine("MatKor");
                    break;
                case "W":
                    Console.WriteLine("WiCys");
                    break;
                case "C":
                    Console.WriteLine("CyKor");
                    break;
                case "A":
                    Console.WriteLine("AlKor");
                    break;
                case "$":
                    Console.WriteLine("$clear");
                    break;
            }
        }
    }
}