using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitRoller
{
    class BitRoller
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int frozenBit = int.Parse(Console.ReadLine());
            int rollingNum = int.Parse(Console.ReadLine());
            int frozenMunus = frozenBit - 1;
            int frozenPlus = frozenBit + 1;
            int startIndex = 0;
            int endIndex = 18;
            if (frozenBit == 18 || frozenBit == 0)
            {
                if (frozenBit == 18)
                {
                    frozenPlus = 0;
                    endIndex = 17;
                }
                else
                {
                    frozenMunus = 18;
                    startIndex = 1;
                }
            }

            for (int i = 0; i < rollingNum; i++)
            {
                int mask = 1;
                bool check = ((number >> startIndex) & mask) == 1;
                bool checkLeftBit = ((number >> frozenPlus) & mask) == 1;
                number = number >> 1;
                if (check)
                {
                    number = number | (mask << endIndex);
                }
                if (checkLeftBit)
                {
                    number = number | (mask << frozenMunus);
                }

                if (!checkLeftBit)
                {
                    bool isOne = ((number >> frozenMunus) & mask) == 1;
                    if (isOne)
                    {
                        if (frozenMunus != 0)
                        {
                            number = number ^ (mask << frozenMunus);
                        }

                    }
                    else
                    {
                        if (frozenMunus == 0)
                        {
                            continue;
                        }
                        number = number & (mask << frozenMunus);
                    }
                }
                number = number | (mask << frozenBit);


            }
            Console.WriteLine(number);

        }
    }
}

