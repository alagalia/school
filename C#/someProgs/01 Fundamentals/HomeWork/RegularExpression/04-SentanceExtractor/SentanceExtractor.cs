using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProbExtractEmails;

namespace ProbSentanceExtractor
{
    class SentanceExtractor
    {
        static void Main()
        {
            string inputText = Console.ReadLine();

            string pattern = @"(?![\.!\?])([A-Za-z\s]+\bis\s+[A-Za-z\s]+[!\.?])";

            ExtractEmails.ExtractFromText(inputText, pattern);
        }
    }
}
