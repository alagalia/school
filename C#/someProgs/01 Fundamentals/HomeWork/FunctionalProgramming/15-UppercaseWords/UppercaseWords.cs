using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security;
using System.Text.RegularExpressions;

namespace UppercaseWords
{
    class UppercaseWords
    {
        static void Main()
        {
            string text = Console.ReadLine();
            
            List<string> finalText = new List<string>();

            while (text != "END")
            {
                StringBuilder secElement = new StringBuilder();
                for (int i = 0; i < text.Length; i++)
                {
                    string support = SecurityElement.Escape(text[i].ToString());
                    secElement.Append(support);
                }
                text = secElement.ToString();

                string pattern = @"\b[A-Z]+(?=\d)|(?<=\d)[A-Z]+\b|\b[A-Z]+\b";
                Regex regex = new Regex(pattern);
                MatchCollection mColection = regex.Matches(text);

                List<string> matches = new List<string>();

                foreach (Match item in mColection)
                {
                    string upperPattern = item.Value.ToString();
                    if (!matches.Contains(upperPattern))
                    {
                        matches.Add(upperPattern);
                        string support = item.Value.ToString();
                        string aa = @"\b" + support + @"\b|\b"+support+@"(?=\d)|(?<=\d)"+support+@"\b";
                        regex = new Regex(aa);

                        string replace = string.Empty;

                        StringBuilder equal = new StringBuilder();

                        for (int i = upperPattern.Length - 1; i >= 0; i--)
                        {
                            equal.Append(upperPattern[i]);
                        }
                        if (upperPattern.Equals(equal.ToString()))
                        {
                            equal.Clear();
                            for (int i = 0; i < item.Value.ToString().Length; i++)
                            {
                                equal.Append(upperPattern[i]);
                                equal.Append(upperPattern[i]);
                            }
                            replace = equal.ToString();
                        }
                        else
                        {
                            replace =equal.ToString();
                        }
                        text = regex.Replace(text, replace);
                    }
                    else
                    {
                    }
                }
                finalText.Add(text);
                text = Console.ReadLine();
            }
            for (int i = 0; i < finalText.Count; i++)
            {
                Console.WriteLine(finalText[i]);
            }
        }
    }
}
