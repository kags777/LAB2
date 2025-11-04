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

                // Разбиваем строку на слова
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
    }
}
