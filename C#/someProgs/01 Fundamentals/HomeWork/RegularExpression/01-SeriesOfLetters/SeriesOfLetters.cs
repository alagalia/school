using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProblemSeriesOfLetters
{
    public class SeriesOfLetters
    {
        static void Main()
        {
            string text = "aaaaabbbbbcdddeeeedssaa";
            string pattern = @"(.)\1+";
            string replacedWith = "$1";

            
            Console.WriteLine(RegexReplace(text, pattern, replacedWith));

        }

        public static string RegexReplace(string text, string pathern, string replacedWith)
        {
            Regex regex = new Regex(pathern);
            text = regex.Replace(text, replacedWith);
            return text;
        }
    }
}
