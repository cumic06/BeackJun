using System;
using System.Text;

namespace ACMHotel
{
    class Program
    {
        static void Main()
        {
            int t = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < t; i++)
            {
                string[] hwn = Console.ReadLine().Split();

                int roomFloor = int.Parse(hwn[0]);
                int room = int.Parse(hwn[1]);
                int guest = int.Parse(hwn[2]);

                int floor = guest % roomFloor;
                int lastRoomNum = guest / roomFloor + 1;

                if (floor == 0)
                {
                    floor = roomFloor;
                    lastRoomNum--;
                }

                sb.Append($"{floor}");

                if (lastRoomNum < 10)
                {
                    sb.Append($"0{lastRoomNum}");
                }
                else
                {
                    sb.Append($"{lastRoomNum}");
                }
                sb.Append("\n");
            }
            Console.WriteLine(sb);
        }
    }
}