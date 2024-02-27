using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WordSort
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> wordsHash = new HashSet<string>();
            List<string> wordsList = new List<string>();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                wordsList.Add(word);
            }
            wordsList.Sort((x, y) => string.Compare(x, y));
            wordsHash = wordsList.ToHashSet();
            wordsHash = wordsHash.OrderBy((a) => a.Length).ToHashSet();

            foreach (var word in wordsHash)
            {
                sb.AppendLine(word);
            }

            Console.WriteLine(sb.ToString());
        }
    }
}