using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemTextFilter
{
    class TextFilter
    {
        static void Main()
        {
            string[] bannedWords = Console.ReadLine().Split(new char[] {',',' '},StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();

            Console.WriteLine();

            FilsteredText(bannedWords, text);
        }

        private static void FilsteredText(string[] bannedWords, string text)
        {
            string replacedText = string.Empty;

            for (int i = 0; i < bannedWords.Length; i++)
            {
                int lenght =bannedWords[i].Length;
                string newString = new string('*', lenght);
                replacedText = text.Replace(bannedWords[i], newString);
                text = replacedText;
            }
            Console.WriteLine(replacedText);
        }
    }
}
