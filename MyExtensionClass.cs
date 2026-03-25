using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace lab5
{
    public static class MyExtensionClass
    {
        public static string FirstTask(this string str)
        {
            if (str == null) throw new ArgumentNullException(nameof(str));

            string[] words = str.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                char[] letter = words[i].ToCharArray();

                for (int j = 0; j < letter.Length; j++)
                {
                    if (j % 2 == 0)
                        letter[j] = char.ToUpper(letter[j]);
                    else
                        letter[j] = char.ToLower(letter[j]);
                }

                words[i] = new string(letter);
            }

            return string.Join(" ", words);
        }

        public static string SecondTask(this string str)
        {
            if (str == null) throw new ArgumentNullException(nameof(str));
            return new string(str.Where(c => !"aeuioyAEUIOY".Contains(c)).ToArray());
        }

        public static int[] ThirdTask(this string str)
        {
            if (str == null) throw new ArgumentNullException(nameof(str));
            string[] words = str.Split(' ');
            int[] counts = new int[words.Length];
            for (int i = 0; i < words.Length; i++)
            {
                counts[i] = words[i].Count(/*c => char.IsLetter(c)*/);
            }
            return counts;
        }
        public static bool FourthTask(this string str)
        {
            if (!char.IsUpper(str[0])) return false;
            str = str.Trim();
            char last = str[str.Length - 1];
            if (last != '.' && last != '!' && last != '?') return false;
            return !str.Substring(0, str.Length - 1).Any(c => c == '.' || c == '!' || c == '?');
        }

        public static T FifthTask<T>(this IEnumerable<T> str)
        {
            return str.GroupBy(x => x).OrderByDescending(g => g.Count()).First().Key;
        }
    }
}
