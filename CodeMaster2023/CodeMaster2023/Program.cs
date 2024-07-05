using System;

namespace CodeMaster2023
{
    class Program
    {
        static void Main()
        {
            string str = Console.ReadLine();
            switch (str)
            {
                case "SONGDO":
                    Console.WriteLine("HIGHSCHOOL");
                    break;
                case "CODE":
                    Console.WriteLine("MASTER");
                    break;
                case "2023":
                    Console.WriteLine("0611");
                    break;
                case "ALGORITHM":
                    Console.WriteLine("CONTEST");
                    break;
            }
        }
    }
}