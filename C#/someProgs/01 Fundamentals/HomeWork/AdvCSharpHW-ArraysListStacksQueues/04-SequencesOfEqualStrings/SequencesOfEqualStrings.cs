using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SequencesOfEqualStrings
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ').ToArray();

        var result = from grupite in input
                     group grupite by grupite
                         into grupa
                         select grupa ;

        foreach (var grupite in result)
        {
            foreach (var grupa in grupite)
            {
                Console.Write("{0} ", grupa);
            }
            Console.WriteLine();
        }
        
        Console.WriteLine();
        
    }
}

