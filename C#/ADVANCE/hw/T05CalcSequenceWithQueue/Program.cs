using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T05CalcSequenceWithQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            long theNum = long.Parse(Console.ReadLine());

            Queue<long> members = new Queue<long>();

            List<long> toPrint = new List<long>();

            members.Enqueue(theNum);
            toPrint.Add(theNum);

            while (true)
            {
                long member = members.First();

                long a = member + 1;
                long b = 2 * member + 1;
                long c = member + 2;

                members.Enqueue(a);
                members.Enqueue(b);
                members.Enqueue(c);
                members.Dequeue();

                toPrint.Add(a);
                toPrint.Add(b);
                toPrint.Add(c);

                if (toPrint.Count() >= 50)
                {
                    break;
                }
            }

            if (toPrint.Count() > 50)
            {
                for (int i = toPrint.Count(); i > 50; i--)
                {
                    toPrint.RemoveAt(i-1);
                }
            }

            Console.WriteLine(string.Join(" ", toPrint));


        }
    }
}
