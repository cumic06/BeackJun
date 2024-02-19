using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMHotel
{
    class Program
    {
        static int[,] acm;

        static void Main()
        {
            int t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                string[] hwn = Console.ReadLine().Split();

                int roomFloor = int.Parse(hwn[0]);
                int room = int.Parse(hwn[1]);
                int guest = int.Parse(hwn[2]);

                acm = new int[room, roomFloor];

                //if (!CheckIsFullRoom(guest))
                //{

                //}
            }
        }

        //static bool CheckIsFullRoom(int guest)
        //{
        //    if (guest)
        //    {

        //    }
        //}

        //static void InRoom()
        //{

        //}
    }
}
