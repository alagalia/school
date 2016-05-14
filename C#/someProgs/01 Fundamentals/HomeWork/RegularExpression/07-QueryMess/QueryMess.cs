using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProbQueryMess
{
    class QueryMess
    {
        static void Main()
        {
            string inputText = Console.ReadLine();

            List<string> result = new List<string>();

            result.Add(ExtractKeyAndValue(inputText));

            while (inputText != "END")
            {
                inputText = Console.ReadLine();
                if (inputText == "END")
                {
                    break;
                }
                result.Add(ExtractKeyAndValue(inputText));
            }
            foreach (var results in result)
            {
                Console.WriteLine(results);
            }
        }
        private static string ExtractKeyAndValue (string inputText)
        {
            string pattern = @"(?<keys>[^?=&]+)=(?<value>[^&\n]+)";

            Regex regex = new Regex(pattern);

            MatchCollection extractKeyValue = regex.Matches(inputText);

            Dictionary<string, List<string>> supResult = new Dictionary<string, List<string>>();

            foreach (Match pair in extractKeyValue)
            {
                string key = pair.Groups["keys"].Value;
                string value = pair.Groups["value"].Value;

                key = ReplaceSpaces(key);
                value = ReplaceSpaces(value);

                if (!supResult.ContainsKey(key))
                {
                    List<string> listOfDic = new List<string>();
                    listOfDic.Add(value);
                    supResult.Add(key, listOfDic);
                }
                else
                {
                    supResult[key].Add(value);
                }

            }
            string tempValue = string.Empty;
            string tempKey = string.Empty;
            string finalString = string.Empty;
            StringBuilder sb = new StringBuilder();

            foreach (var item in supResult)
            {
                tempKey = item.Key;
                tempValue = string.Join(", ", item.Value);
                finalString = tempKey + "=[" + tempValue + "]";
                sb.Append(finalString);
                //result.Add(finalString); 
                
            }
            finalString = sb.ToString();
            return finalString;
        }
        private static string ReplaceSpaces(string key)
        {
            string reWorked = key;

            string plus = @"\+";
            string percentTwenty = "%20";
            string manySpaces = @"\s+";

            Regex replaced = new Regex(plus);
            reWorked = replaced.Replace(reWorked, " ");

            replaced = new Regex(percentTwenty);
            reWorked = replaced.Replace(reWorked, " ");

            replaced = new Regex(manySpaces);
            reWorked = replaced.Replace(reWorked, " ");

            reWorked = reWorked.Trim();

            return reWorked;
        }
    }
}
