using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T06TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int nPumps = int.Parse(Console.ReadLine());

            List<string> asString = new List<string>();
            Queue<string> cmd = new Queue<string>();

            if (nPumps >= 1 && nPumps <= 1000001)
            {

                for (int i = 0; i < nPumps; i++)
                {
                    string support = Console.ReadLine();
                    asString.Add(support);
                    cmd.Enqueue(support);
                }

                int count = 0;

                string begin = string.Empty;

                while (count != nPumps)
                {                  

                    long quantity = 0L;
                    long distance = 0L;
                    bool hasStart = true;

                    foreach (var pump in cmd)
                    {
                        long[] input = pump.Trim()
                        .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(long.Parse).ToArray();

                        quantity += input[0];
                        distance += input[1];

                        if (quantity < distance)
                        {
                            hasStart = false;
                            break;
                        }

                    }
                    if (hasStart)
                    {
                        begin = cmd.First();
                        break;
                    }

                    string firstLast = cmd.First();
                    cmd.Dequeue();

                    cmd.Enqueue(firstLast);

                    count++;
                }

                if (!string.IsNullOrEmpty(begin))
                {
                    int index = asString.IndexOf(begin);
                    Console.WriteLine(index);
                }
  
            }

            
        }
    }
}
