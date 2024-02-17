using System;

namespace SoundScale
{
    class Program
    {
        static void Main()
        {
            string str = Console.ReadLine();

            string strString = "";

            string ascending = "1 2 3 4 5 6 7 8";
            string descending = "8 7 6 5 4 3 2 1";

            if (str == ascending)
            {
                strString = "ascending";
            }
            else if (str == descending)
            {
                strString = "descending";
            }
            else
            {
                strString = "mixed";
            }
            Console.WriteLine(strString);
        }
    }
}