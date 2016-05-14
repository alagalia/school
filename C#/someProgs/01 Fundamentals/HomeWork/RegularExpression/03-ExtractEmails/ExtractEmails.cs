using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProbExtractEmails
{
    public class ExtractEmails
    {
        static void Main()
        {
            string inputText = Console.ReadLine();

            string pattern = @"(?<![\.\-_])(\b[a-zA-Z0-9]+\.?\-?\w+)@(\w+(?:\-\w+)?(?:\-?\w+?\.?\w+?))\.([a-zA-Z]+)";
            
            ExtractFromText(inputText, pattern);
        }

        public static void ExtractFromText(string inputText, string pattern)
        {
            Regex extract = new Regex(pattern);
            MatchCollection extractEmails = extract.Matches(inputText);

            Console.WriteLine();

            foreach (Match email in extractEmails)
            {
                Console.WriteLine(email);
            }
        }
    }
}
