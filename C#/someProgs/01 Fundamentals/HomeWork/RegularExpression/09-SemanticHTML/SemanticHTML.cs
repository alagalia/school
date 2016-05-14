using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProbSemanticHTML
{
    class SemanticHTML
    {
        static void Main()
        {
            string inputText = string.Empty;

            List<string> validHTML = new List<string>();

            string pattern = @"(?:(?<space>\s*)<div(?<contain>.+)?(?:id|class)\s*=\s*""(?<name>[^""]+)""\s*(?<contain1>.+)?>)|((?<space1>\s*)<\s*\/\s*div\s*>\s*<!--\s*(?<name1>[^\s]+)\s*-->)";

            Regex regex = new Regex(pattern);          
            
            while (true)
            {
                inputText = Console.ReadLine();

                if (inputText == "END") { break; }

                MatchCollection htmlNew = regex.Matches(inputText);
                //Match htmlOld = regex.Match(inputText);

                if (htmlNew.Count > 0)
                {
                    foreach (Match htmlTag in htmlNew)
                    {
                        string supportStr = string.Empty;
                       
                        if (htmlTag.Groups["name1"].Value == "")
                        {
                            string tag = htmlTag.Groups["name"].Value.Trim();
                            string contain = htmlTag.Groups["contain"].Value.Trim();
                            string contain1 = htmlTag.Groups["contain1"].Value.Trim();

                            supportStr = "<" + tag + " "; // +contain + " " + contain1 + ">";
                            if ((contain == string.Empty) &&(contain1 == string.Empty))
                            {
                                supportStr = "<" + tag + ">";
                            }
                            else if (contain == string.Empty)
                            {
                                supportStr = supportStr + contain1 + ">";
                            }
                            else if (contain1 == string.Empty)
                            {
                                supportStr = supportStr + contain + ">";
                            }                            
                            else
                            {
                                supportStr = supportStr + contain + " " + contain1 + ">";
                            }
                            string patternSpace = @"\s+";
                            Regex space = new Regex(patternSpace);

                            supportStr = space.Replace(supportStr, " ");

                            string spaceGroupOne = htmlTag.Groups["space"].Value;
                            supportStr = spaceGroupOne + supportStr;

                            validHTML.Add(supportStr);
                        }
                        else
                        {
                            string tag1 = htmlTag.Groups["name1"].Value.Trim();
                            string space1 = htmlTag.Groups["space1"].Value;
                            string supStr = space1 + @"</" + tag1 + ">";

                            //string spaceGroupOne = htmlTag.Groups["space1"].Value;
                            //supportStr = spaceGroupOne + supportStr;

                            validHTML.Add(supStr);
                        }

                    }
                }
                else
                {
                    validHTML.Add(inputText);
                }                             
            }
            foreach (var row in validHTML)
            {
                Console.WriteLine(row);
            }
        }
    }
}
