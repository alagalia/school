using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Illuminati
{
    static void Main()
    {
        string message = Console.ReadLine();
        message = message.ToUpper();
        ulong sumOfVowels = 0ul;
        int countOfVowels = 0;

        for (int i = 0; i < message.Length; i++)
        {

            
            char readingChar = message[i];
            
            int charAsInt = Convert.ToInt32(readingChar);

            switch (charAsInt)
            {
                case 65: sumOfVowels += 65;
                    countOfVowels++;
                    break;
                case 69: sumOfVowels += 69;
                    countOfVowels++;
                    break;
                case 73: sumOfVowels += 73;
                    countOfVowels++;
                    break;
                case 79: sumOfVowels += 79;
                    countOfVowels++;
                    break;
                case 85: sumOfVowels += 85;
                    countOfVowels++;
                    break;
            }

        }
        Console.WriteLine("{0}",countOfVowels);
        Console.WriteLine("{0}", sumOfVowels);
    }
}

