using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CountSymbols
{
    static void Main()
    {
        string input = Console.ReadLine();

        SortedDictionary<char, int> characters = new SortedDictionary<char, int>();

        for (int i = 0; i < input.Length; i++)
        {
            char currentChar = input[i];
            if (!characters.ContainsKey(currentChar))
            {
                characters.Add(currentChar, 1);

            }
            else
            {
                int count = characters[currentChar];
                count++;
                characters[currentChar] = count;

            }
        }
        foreach (var symbol in characters)
        {
            Console.WriteLine("{0}: {1} time/s",symbol.Key, symbol.Value);
        }
    }
}

