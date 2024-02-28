using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CutLanCable
{
    class Program
    {
        static void Main()
        {
            string[] n = Console.ReadLine().Split();
            int t = int.Parse(n[0]);
            int maxCount = int.Parse(n[1]);

            int b = maxCount / t;

            int count = 0;

            for (int i = 0; i < t; i++)
            {
                int a = int.Parse(Console.ReadLine());

            }
        }
    }
}
