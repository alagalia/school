using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class NightLife
{
    static void Main()
    {
        string input = Console.ReadLine();

        Dictionary<string, SortedDictionary<string, List<string>>> stash = 
            new Dictionary<string, SortedDictionary<string, List<string>>>();

        while (input != "END")
        {
            string[] cvp = input.Split(';').ToArray();

            if (!stash.ContainsKey(cvp[0]))
            {
                List<string> list = new List<string>();
                list.Add(cvp[2]);
                SortedDictionary<string, List<string>> sortDic =
                    new SortedDictionary<string, List<string>>();
                sortDic.Add(cvp[1], list);
                stash.Add(cvp[0], sortDic);

            }
            else
            {
                if (!stash[cvp[0]].ContainsKey(cvp[1]))
                {
                    List<string> list = new List<string>();
                    list.Add(cvp[2]);
                    stash[cvp[0]].Add(cvp[1], list);
                }
                else if (!stash[cvp[0]][cvp[1]].Contains(cvp[2]))
                {

                    stash[cvp[0]][cvp[1]].Add(cvp[2]); 
                }
                else
                {
                    input = Console.ReadLine();
                    continue;
                }
            }
            input = Console.ReadLine();
        }
        foreach (var city in stash)
        {
            Console.WriteLine(city.Key);
            foreach (var venue in city.Value)
            {
                venue.Value.Sort();
                Console.WriteLine("->{0}: {1}", venue.Key, string.Join(", ",venue.Value));
            }
        }
        Console.WriteLine();
    }
}

