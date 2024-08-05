using System;
using System.Text;

namespace ISpeakTXTMSG
{
    internal class Program
    {
        static void Main()
        {
            string str = "";
            StringBuilder sb = new StringBuilder();

            while (true)
            {
                str = Console.ReadLine();
                switch (str)
                {
                    case "CU":
                        sb.AppendLine("see you");
                        break;
                    case ":-)":
                        sb.AppendLine("I’m happy");
                        break;
                    case ":-(":
                        sb.AppendLine("I’m unhappy");
                        break;
                    case ";-)":
                        sb.AppendLine("wink");
                        break;
                    case ":-P":
                        sb.AppendLine("stick out my tongue");
                        break;
                    case "(~.~)":
                        sb.AppendLine("sleepy");
                        break;
                    case "TA":
                        sb.AppendLine("totally awesome");
                        break;
                    case "CCC":
                        sb.AppendLine("Canadian Computing Competition");
                        break;
                    case "CUZ":
                        sb.AppendLine("because");
                        break;
                    case "TY":
                        sb.AppendLine("thank-you");
                        break;
                    case "YW":
                        sb.AppendLine("you’re welcome");
                        break;
                    case "TTYL":
                        sb.AppendLine("talk to you later");
                        break;
                    default:
                        sb.AppendLine(str);
                        break;
                }
                if (str == "TTYL") break;
            }
            Console.WriteLine(sb.ToString().Trim());
        }
    }
}