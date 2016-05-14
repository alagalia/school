using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProbUseYourChainsBuddy
{
    class UseYourChainsBuddy
    {
        static void Main()
        {
            Console.SetIn(new StreamReader(Console.OpenStandardInput(8192)));

            string inputText = Console.ReadLine();

            string pattern = @"<p>(?<text>[^\/]+)<\/p>";

            Regex regex = new Regex(pattern);

            MatchCollection matched = regex.Matches(inputText);

            List<string> formattedText = new List<string>();

            foreach (Match tag in matched)
            {
                formattedText.Add(TextEdit(tag.Groups["text"].Value));
            }

            Console.WriteLine();
            string editedText = string.Join("",formattedText);
            Console.WriteLine(RemoveTwoOrMoreSpaces(editedText));
            
        }

        private static string TextEdit(string unformatted)
        {
            StringBuilder editedText = new StringBuilder();

            string pattern = @"[^a-z0-9]";
            Regex regex = new Regex(pattern);

            unformatted = regex.Replace(unformatted, " ");

            

            //unformatted = regex.Replace(unformatted, " ");

            for (int i = 0; i < unformatted.Length; i++)
            {
                if ((int)unformatted[i] == 32 || ((int)unformatted[i] > 47 && (int)unformatted[i] < 58))
                {
                    editedText.Append(unformatted[i]);
                }
                else if ((int)unformatted[i] < 110)
                {
                    editedText.Append((char)((int)unformatted[i] + 13));
                }
                else
                {
                    editedText.Append((char)((int)unformatted[i] - 13));
                }
            }
            return editedText.ToString();
        }
        private static string RemoveTwoOrMoreSpaces(string text)
        {
            string pattern = @"\s+";
            Regex regex = new Regex(pattern);
            text = regex.Replace(text, " ");

            return text;
        }

    }
}
