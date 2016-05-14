using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExtractHyperlinks
{
    class ExtractHyperlinks
    {
        static void Main()
        {
            string inputText = Console.ReadLine();

            string pattern = @"<a\s*[^>]*href\s*=\s*(?:""(?<url>[^""]*)""|'(?<url1>[^']*)'|(?<url2>[^\s>]+))[^<]*>";

            Regex regex = new Regex(pattern);

            StringBuilder mergeText = new StringBuilder();   
            /*
             * Не знам защо регекс-а не работи когато се чете ред по ред от конзолата ...
             * и трябва инпута да бъде като един стринг без нови редове 
             * */
            while (inputText != "END")
            {
                mergeText.Append(inputText);
                inputText = Console.ReadLine();
                //regMatch = regex.Matches(inputText); 
            }

            inputText = mergeText.ToString();

            MatchCollection regMatch = regex.Matches(inputText);

            foreach (Match urlMatch in regMatch)
            {
                Console.WriteLine("{0}{1}{2}", urlMatch.Groups["url"], urlMatch.Groups["url1"], urlMatch.Groups["url2"]);
            }
        }
    }
}
