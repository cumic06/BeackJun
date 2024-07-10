using System;
using System.Text;

namespace PromotionSeminar
{
    class Program
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string str = Console.ReadLine();

                switch (str)
                {
                    case "Algorithm":
                        sb.AppendLine("204");
                        break;
                    case "DataAnalysis":
                        sb.AppendLine("207");
                        break;
                    case "ArtificialIntelligence":
                        sb.AppendLine("302");
                        break;
                    case "CyberSecurity":
                        sb.AppendLine("B101");
                        break;
                    case "Network":
                        sb.AppendLine("303");
                        break;
                    case "Startup":
                        sb.AppendLine("501");
                        break;
                    case "TestStrategy":
                        sb.AppendLine("105");
                        break;
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}