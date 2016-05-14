using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemUnicodeCharacters
{
    class UnicodeCharacters
    {
        static void Main()
        {
            string someText = Console.ReadLine();

            foreach (var ch in someText)
            {
                Console.Write("\\u{0:x4}",(int)ch);
            }
            Console.WriteLine();

        }
    }
}
