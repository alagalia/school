using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemStringLenght
{
    class StringLenght
    {
        static void Main()
        {
            string someInput = Console.ReadLine();

            StringBuilder modifiedString = new StringBuilder(someInput);

            if (someInput.Length < 20)
            {
                
                for (int i = someInput.Length ; i < 20; i++)
                {
                    modifiedString.Append("*");
                }
            }
            Console.WriteLine(modifiedString);
        }
    }
}
