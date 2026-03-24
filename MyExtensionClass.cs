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
            for(int i = 0; i < words.Length; i++)
            {
                counts[i] = words[i].Count(/*c => char.IsLetter(c)*/);
            }
            return counts;
        }
    }
}
