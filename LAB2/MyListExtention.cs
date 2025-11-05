using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2
{
    public static class MyListExtensions
    {
        public static int CountWordsStartingWithUpper(this MyList<string> list)
        {
            int count = 0;

            foreach (var str in list)
            {
                if (string.IsNullOrWhiteSpace(str))
                    continue;

                var words = str.Split(new char[] { ' ', '\t', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

                // Считаем слова с заглавной буквы
                foreach (var word in words)
                {
                    if (char.IsUpper(word[0]))
                        count++;
                }
            }
            return count;
        }

        public static void CountRepeatedWords(this MyList<string> list)
        {
            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            foreach (var str in list)
            {
                if (string.IsNullOrWhiteSpace(str))
                    continue;

                var words = str.Split(new char[] { ' ', '\t', '.', ',', '!', '?' },
                    StringSplitOptions.RemoveEmptyEntries);

                foreach (var w in words)
                {
                    string word = w.ToLower(); 

                    if (wordCount.ContainsKey(word))
                        wordCount[word]++;
                    else
                        wordCount[word] = 1;
                }
            }

            Console.WriteLine("\nПовторяющиеся слова:");
            foreach (var pair in wordCount)
            {
                if (pair.Value > 1)
                    Console.WriteLine($"{pair.Key} — {pair.Value} раз(а)");
            }
        }
    }
}
