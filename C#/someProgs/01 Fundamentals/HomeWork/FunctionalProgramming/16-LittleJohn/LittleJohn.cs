using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LittleJohn
{
    class LittleJohn
    {
        static void Main()
        {
            string[] text = new string[4];

            for (int i = 0; i < 4; i++)
            {
                text[i] = Console.ReadLine();
            }

            string pattern = @"(>{3}-{5}>{2})+|(>{2}-{5}>)+|(>-{5}>)+";

            int smallArrow = 0;
            int middleArrow = 0;
            int bigArrow = 0;

            Regex regex = new Regex(pattern);
            
            for (int i = 0; i < 4; i++)
            {
                MatchCollection mColection = regex.Matches(text[i]);

                foreach (Match item in mColection)
                {
                    bigArrow += item.Groups[1].Captures.Count;
                    middleArrow += item.Groups[2].Captures.Count;
                    smallArrow += item.Groups[3].Captures.Count;
                }
            }

            string numAsString = smallArrow + "" + middleArrow + "" + bigArrow;
            int toDecimal = int.Parse(numAsString);
            numAsString = Convert.ToString(toDecimal, 2);
            StringBuilder sb = new StringBuilder(numAsString);

            for (int i = numAsString.Length - 1; i >= 0 ; i--)
            {
                sb.Append(numAsString[i]);
            }
            toDecimal = Convert.ToInt32(sb.ToString(), 2);
            Console.WriteLine(toDecimal);


        }
    }
}
