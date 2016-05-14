using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class EmergencyRepair
{
    static void Main()
    {
        ulong wall = ulong.Parse(Console.ReadLine());
        int emergencyKits = int.Parse(Console.ReadLine());
        int kitsleft = emergencyKits;

        int numberOfAttacks = int.Parse(Console.ReadLine());
        int[] attackedBits = new int [numberOfAttacks];

        bool isOne = false;
        bool isOneToo = false;

        // attack <<--0
        for (int i = 0; i < numberOfAttacks; i++)
        {
            attackedBits[i] = int.Parse(Console.ReadLine());

        }

        for (int i = 0; i < attackedBits.Length; i++)
        {
            ulong mask = 1UL;
            mask = mask << attackedBits[i];
            isOne = ((wall >> attackedBits[i]) & 1UL) == 1;

            if (isOne)
            {
                wall &= ~mask;
            }
            

        }

        List<int> repairing = new List<int>();

        bool a = false;

        for (int i = 1; i < 64; i++)
        {
            isOne = ((wall >> i) & 1UL) == 0;

            //if (!isOne)
            //{
            //    a = false;
            //}

            if (!a)
            {
                isOneToo = ((wall >> i - 1) & 1UL) == 0;
            }
            else
            {
                isOneToo = ((wall >> i - 1) & 1UL) == 1;
                a = false;
            }
            

            if (isOne && isOneToo)
            {
                ulong mask = 1UL;

                if (emergencyKits > 1)
                {
                    mask = 1UL;
                    mask = mask << i;

                    ////
                    if (kitsleft == 1)/////
                    {
                        mask = 1UL;
                        mask = mask << i-1;

                        if (!repairing.Contains(i-1))
                        {
                            wall |= mask;
                            repairing.Add(i-1);
                            kitsleft--;
                        }

                        if (kitsleft == 0)
                        {
                            break;
                        }
                    }
                    /////
                    mask = 1UL;
                    mask = mask << i;

                    if (!repairing.Contains(i))
                    {
                        wall |= mask;
                        repairing.Add(i);
                        kitsleft--;
                        a = true;
                    }
                    if (kitsleft == 0)
                    {
                        break;
                    }

                    mask = 1UL;
                    mask = mask << i - 1;

                    if (!repairing.Contains(i - 1))
                    {
                        wall |= mask;
                        repairing.Add(i - 1);
                        kitsleft--;
                        a = true;
                    }

                    if (kitsleft == 0)
                    {
                        break;
                    }
                }

                if (emergencyKits == 1)/////
                {
                    mask = 1UL;
                    mask = mask << i - 1;

                    if (!repairing.Contains(i - 1))
                    {
                        wall |= mask;
                        repairing.Add(i - 1);
                        kitsleft--;
                    }

                    if (kitsleft == 0)
                    {
                        break;
                    }
                }
                if (emergencyKits == 0)
                {
                    break;
                }
                
                


                
 
            }
        }
        Console.WriteLine(wall);

        


    }
}

