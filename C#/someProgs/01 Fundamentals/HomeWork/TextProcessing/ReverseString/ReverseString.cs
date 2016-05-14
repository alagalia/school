using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemReverseString
{
    public class ReverseString
    {
        static void Main()
        {
            string name = "Ivan";

            Console.WriteLine(StringReverse(name));
            //Console.WriteLine(new string(name.ToCharArray().Reverse().ToArray()));
        }

        public static string StringReverse(string name)
        {
            string revString = new string(name.ToCharArray().Reverse().ToArray());
            return revString;
        }
    }
}
