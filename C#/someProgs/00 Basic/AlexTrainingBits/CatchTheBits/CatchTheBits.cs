using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CatchTheBits
{
    static void Main()
    {
        byte numOfNums = byte.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());

        byte[] numbers = new byte[numOfNums];

        for (int i = 0; i < numOfNums; i++)
        {
            numbers[i] = byte.Parse(Console.ReadLine());
        }

        Console.WriteLine();

        int middleNum = 0;
        int mask = 1;
        int startIndex = 6;
        int index = startIndex;
        int count = 0;
        int lenghtOfNewNum = 1;
        int finalNum = 0;
        int skipNums = 0;
        int isPrint = 0;

        foreach (var num in numbers)
        {
            while (startIndex >= 0)
            {

                if (skipNums != 0)
                {

                    skipNums--;
                    break;
                }

                bool isOne = ((num >> startIndex) & mask) == 1;

                if (isOne)
                {
                    if (count != 0)
                    {
                        middleNum = (middleNum << 1) | mask;
                        lenghtOfNewNum++;

                    }
                    else
                    {
                        middleNum = middleNum | mask;
                        count++;
                        lenghtOfNewNum++;
                    }

                }
                else
                {
                    if (count != 0)
                    {
                        middleNum = (middleNum << 1) | 0;
                        lenghtOfNewNum++;
                    }
                    else
                    {
                        middleNum = middleNum & mask;
                        count++;
                        lenghtOfNewNum++;
                    }
                }

                

                if (lenghtOfNewNum == 9)
                {
                    lenghtOfNewNum = 1;
                    finalNum = middleNum;
                    Console.WriteLine(finalNum);
                    middleNum = 0;
                    isPrint++;

                }

                int curruntIndex = startIndex;
                startIndex -= step;

                if (startIndex < 0)
                {
                    int remainder = step % 8;

                    startIndex = curruntIndex - remainder;
                    if (startIndex < 0 && (step <= 8))
                    {
                        startIndex = 8 - Math.Abs(startIndex);
                    }
                    else
                    {

                        if (startIndex < 0 && (step > 8))
                        {
                            startIndex = 8 - Math.Abs(startIndex);
                            skipNums = Math.Abs((curruntIndex + step) / 8);
                        }
                        
                    }

                    
                    break;
                }
            }
           
        }


        
        //int count = 0;


        finalNum = middleNum;

        int padding = 8 - lenghtOfNewNum + 1;
        if (padding == 8)
        {
            padding = 0;
            
        }
        finalNum = finalNum << padding;

        if ( finalNum != 0)
        {
            Console.WriteLine(finalNum);
        }
        
        
       
        
    }
}

