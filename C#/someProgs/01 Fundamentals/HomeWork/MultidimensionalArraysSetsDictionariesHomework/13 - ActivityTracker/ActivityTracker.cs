using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ActivityTracker
{
    static void Main()
    {
        int numOfInput = int.Parse(Console.ReadLine());

        //string[] inputData = new string [numOfInput];
        SortedDictionary<int, SortedDictionary<string, decimal>> collectedData =
            new SortedDictionary<int, SortedDictionary<string, decimal>>();

        for (int i = 0; i < numOfInput; i++)
        {
            string [] inputData = Console.ReadLine().Split();

            int[] month = inputData[0].Split('/').Select(int.Parse).ToArray();

            if (!collectedData.ContainsKey(month[1]))
            {
                SortedDictionary<string, decimal> nameAndLenght = new SortedDictionary<string, decimal>();
                nameAndLenght.Add(inputData[1], decimal.Parse(inputData[2]));
                collectedData.Add(month[1], nameAndLenght);
            }
            else
            {
                if (!collectedData[month[1]].ContainsKey(inputData[1]))
                {
                    collectedData[month[1]].Add(inputData[1], decimal.Parse(inputData[2]));
                }
                else
                {
                    decimal lenght = collectedData[month[1]][inputData[1]];
                    lenght += decimal.Parse(inputData[2]);
                    collectedData[month[1]][inputData[1]] = lenght;

                }
            }
        }
        
        foreach (var monthKey in collectedData)
        {
            Console.Write("{0}: ", monthKey.Key);

            //var sorted = monthKey.Value.OrderByDescending(x => x.Value);
            List<string> inOneStr = new List<string>();

            foreach (var lenght in monthKey.Value)
            {
                string str = lenght.Key + "(" + lenght.Value + ")";
                inOneStr.Add(str);
                //Console.Write(" {0}({1})", lenght.Key, String.Join(", ", lenght));
            }
            Console.Write("{0}",  String.Join(", ", inOneStr));
            Console.WriteLine();
        }
        Console.WriteLine();

        
        
         
    }
}

