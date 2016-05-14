using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProbValidUsernames
{
    class ValidUsernames
    {
        static void Main()
        {
            string inputText = Console.ReadLine();

            string pattern = @"(\b[A-Za-z]+_?[0-9]*[a-zA-Z]*_?[a-zA-Z]*[0-9]*[a-zA-Z]*)";

            CatchValidUsernames(inputText, pattern);
        }

        private static void CatchValidUsernames(string inputText, string pattern)
        {
            List<string> catchedUsers = new List<string>();
            
            Regex regex = new Regex(pattern);

            MatchCollection catchingUsers = regex.Matches(inputText);

            foreach (Match matched in catchingUsers)
            {
                if (matched.Length > 2 && matched.Length < 26)
                {
                    catchedUsers.Add(matched.ToString());
                }
                //Console.WriteLine(matched);
            }
            string firstUser = string.Empty;
            string secondUser = string.Empty;

            for (int i = 0; i < catchedUsers.Count - 1; i++)
            {
                int lenght = catchedUsers[i].Length + catchedUsers[i + 1].Length;
                if (lenght > (firstUser.Length + secondUser.Length))
                {
                    firstUser = catchedUsers[i];
                    secondUser = catchedUsers[i + 1];
                }
            }
            Console.WriteLine(firstUser);
            Console.WriteLine(secondUser);


        }
    }
}
