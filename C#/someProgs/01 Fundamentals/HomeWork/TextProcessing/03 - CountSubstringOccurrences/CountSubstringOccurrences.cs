using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProlemCountSubstringOccurrences
{
    class CountSubstringOccurrences
    {
        static void Main()
        {
            string someText = Console.ReadLine().ToLower();
            string keyWord = Console.ReadLine().ToLower();

            CountSubstring(someText, keyWord);

        }

        private static void CountSubstring(string someText, string keyWord)
        {
            int index = -1;
            int counter = 0;
            bool hasCoincidence = false;
            index = someText.IndexOf(keyWord);
            if (index != - 1)
            {
                hasCoincidence = true;
                counter++;
            }

            while (hasCoincidence)
            {               
                index = someText.IndexOf(keyWord, index + 1);
                if (index != -1)
                {
                    hasCoincidence = true;
                    counter++;
                }
                else
                {
                    hasCoincidence = false;
                }
            }
            if (counter == 0)
            {
                Console.WriteLine("There is no coincidence -> 0");
            }
            else
            {
                Console.WriteLine(counter);
            }
            
        }
    }
}
