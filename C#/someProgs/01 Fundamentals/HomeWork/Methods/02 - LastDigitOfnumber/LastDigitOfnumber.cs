using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastDigitOfnumber
{
    class LastDigitOfnumber
    {
        static void Main()
        {
            string input = Console.ReadLine();

            Console.WriteLine(GetLastDigitAsWord(input));
        }

        private static string GetLastDigitAsWord(string input)
        {
            string word = string.Empty;
            int number = int.Parse(input[input.Length - 1].ToString());
            switch (number)
            {
                case 0: word = "zero";
                    break;
                case 1: word = "one";
                    break;
                case 2: word = "two";
                    break;
                case 3: word = "three";
                    break;
                case 4: word = "four";
                    break;
                case 5: word = "five";
                    break;
                case 6: word = "six";
                    break;
                case 7: word = "seven";
                    break;
                case 8: word = "eight";
                    break;
                case 9: word = "nine";
                    break;

            }
            return word;
        }
    }
}
