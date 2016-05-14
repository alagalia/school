using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProblemSeriesOfLetters;

namespace ProblemReplaceTag
{
    class ReplaceTag
    {
        static void Main()
        {
            string text = Console.ReadLine();
            List<string> replacedText = new List<string>();

            while (text != string.Empty)
            {
                string pattern = @"((<a\shref=""?'?)([\w+:\/\.]+)""?'?>)(\w+)(<\/a>)";
                string replaceWith = @"[URL href=$3]$4[/URL]";

                replacedText.Add(SeriesOfLetters.RegexReplace(text, pattern, replaceWith));

                text = Console.ReadLine();
            }

            Console.WriteLine();

            foreach (var newLine in replacedText)
            {
                Console.WriteLine(newLine);
            }
        }
    }
}
