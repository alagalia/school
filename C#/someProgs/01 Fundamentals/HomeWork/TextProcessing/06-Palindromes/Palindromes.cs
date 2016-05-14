using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProblemReverseString;

namespace ProblemPalindromes
{
    public class Palindromes
    {
        static void Main()
        {
            string someText = Console.ReadLine();

            GetPalindromes(someText);
        }

        public static void GetPalindromes(string someText)
        {
            string[] splitWords = someText.Split(new char[] { ' ', ',', '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);

            List<string> palindromes = new List<string>();

            for (int i = 0; i < splitWords.Length; i++)
            {
                if (splitWords[i] == ReverseString.StringReverse(splitWords[i]))
                {
                    palindromes.Add(splitWords[i]);
                }
            }
            palindromes.Sort();
            Console.WriteLine(string.Join(", ", palindromes));
        }
    }
}
