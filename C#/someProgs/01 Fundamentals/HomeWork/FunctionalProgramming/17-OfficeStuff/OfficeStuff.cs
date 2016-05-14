using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OfficeStuff
{
    class OfficeStuff
    {
        static void Main()
        {
            int numOfInput = int.Parse(Console.ReadLine());

            string text = string.Empty;

            var data = new SortedDictionary<string, Dictionary<string, int>>();

            string pattern = @"(\w+)\s?-\s?(\d+)\s?-\s?(\w+)";

            Regex regex = new Regex(pattern);

            //Match mat4 = new Match();

            for (int i = 0; i < numOfInput; i++)
            {
                text = Console.ReadLine();
                Match mat4 = regex.Match(text);

                string companyName = mat4.Groups[1].Value;
                int numOfProduct = int.Parse(mat4.Groups[2].Value);
                string productName = mat4.Groups[3].Value;

                if (!data.ContainsKey(companyName))
                {
                    int nOfP = numOfProduct;
                    Dictionary<string, int> pName = new Dictionary<string, int>();
                    pName.Add(productName, nOfP);
                    data.Add(companyName, pName);
                }
                else
                {
                    if (!data[companyName].ContainsKey(productName))
                    {
                        int nOfP = numOfProduct;
                        data[companyName].Add(productName, nOfP);
                    }
                    else
                    {
                        int nofp = data[companyName][productName];
                        nofp += numOfProduct;
                        data[companyName][productName] = nofp;
                    }
                }
            }
            foreach (var company in data)
            {             
                string str = string.Join(", ", company.Value);

                Console.WriteLine("{0}: {1}", company.Key, ReplaceValue(str));
            }
            

        }

        private static string ReplaceValue(string str)
        {
            string asd = string.Empty;
            string pattern = @"\[(\w+), (\d+)\]";
            Regex reg = new Regex(pattern);
            asd = reg.Replace(str, @"$1-$2");

            return asd;
        }

        

        
        
    }
}
