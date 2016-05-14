using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLargerThanNeighbours
{
    class FirstLargerThanNeighbours
    {
        static void Main()
        {
            int[] sequenceOne = { 1,3,4,5,1,0,5 };
            int[] sequenceTwo = { 1,2,3,4,5,6,6};
            int[] sequenceThree = { 1, 1, 1};

            Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbours(sequenceOne));
            Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbours(sequenceTwo));
            Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbours(sequenceThree));

        }

        private static int GetIndexOfFirstElementLargerThanNeighbours(int[] array)
        {
            int index = -1;
            //int prevIndex = 0;
            //int nextIndex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                bool isBigger = false;

                if ((i - 1 < 0) || (i + 1 > array.Length - 1))
                {
                    if ((i - 1 < 0) && (i + 1 > array.Length - 1))
                    {
                        isBigger = true;
                    }
                    else if (i - 1 < 0)
                    {
                        isBigger = array[i] > array[i + 1];
                    }
                    else
                    {
                        isBigger = array[i] > array[i - 1];
                    }
                }
                else
                {
                    isBigger = array[i] > array[i - 1];
                    isBigger = array[i] > array[i + 1];
                }
                if (isBigger)
                {
                    index = i;
                    break;
                }
                
            }

            return index;
        }
    }
}
