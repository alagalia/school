using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CrossingSequences
{
    static void Main()
    {
        int numOfTribonacci1 = int.Parse(Console.ReadLine());
        int numOfTribonacci2 = int.Parse(Console.ReadLine());
        int numOfTribonacci3 = int.Parse(Console.ReadLine());

        int startNum = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());

        int[] sortArray = { numOfTribonacci1, numOfTribonacci2, numOfTribonacci3 };
        //Array.Sort(sortArray);

        int smalestNum = 0;
        bool contain = false;

        
        //int firstTri = sortArray[0];
        //int secondTri = sortArray[1];
        //int thirdTri = sortArray[2];

        List<int> tribonacciNums = new List<int>();


        int one = sortArray[0];
        int two = sortArray[1];
        int three = sortArray[2];
        int four = one + two + three;



        tribonacciNums.Add(one);
        tribonacciNums.Add(two);
        tribonacciNums.Add(three);
        tribonacciNums.Add(four);


        while (four < 1000000)
        {
            one = three + two + four;
            tribonacciNums.Add(one);

            two = one + three + four;
            tribonacciNums.Add(two);

            three = one + two + four;
            tribonacciNums.Add(three);

            four = one + two + three;
            tribonacciNums.Add(four);

        }



        int floatingStep = 1;
        int checkFloatinStep = 1;
        int stepOfMatrix = 1;


        for (int i = startNum, k = 1; i <= 1000000; i += step, k++)
        {
            if (k == stepOfMatrix)
            {
                if (tribonacciNums.Contains(i))
                {
                    smalestNum = i;
                    contain = true;
                    break;
                }
                if (checkFloatinStep == 3)
                {
                    checkFloatinStep = 1;
                    floatingStep++;
                }
                checkFloatinStep++;
                stepOfMatrix += floatingStep;

            }
        }
        


        

        if (contain)
        {
            Console.WriteLine(smalestNum);
        }
        else
        {
            Console.WriteLine("No");
        }

        


        //Console.WriteLine();

    }
}

