using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MatrixShuffling
{
    static void Main()
    {
        int[] size = new int[2];

        size[0] = int.Parse(Console.ReadLine());
        size[1] = int.Parse(Console.ReadLine());

        string[,] matrix = new string[size[0], size[1]];

        
        for (int i = 0; i < size[0]; i++)
        {
            for (int j = 0; j < size[1]; j++)
            {
                matrix[i, j] = Console.ReadLine();    
            }
        }

        string comand = Console.ReadLine();

        while (comand != "END")
        {
            if (comand.Contains("swap"))
            {
                string[] supComand = comand.Split(new string[] { "swap", " " }, StringSplitOptions.RemoveEmptyEntries);
                int[] coordinateOfSwap = new int[supComand.Length];

                for (int i = 0; i < supComand.Length; i++)
                {
                    coordinateOfSwap[i] = int.Parse(supComand[i]);
                }
                if (coordinateOfSwap[0] > size[0] || coordinateOfSwap[1] > size[1] || 
                    coordinateOfSwap[2] > size[0] || coordinateOfSwap[3] > size[1])
                {
                    Console.WriteLine("Invalid input!");
                    Console.WriteLine();
                }
                else
                {
                    SwapElements(matrix, size[0], size[1],
                    coordinateOfSwap[0], coordinateOfSwap[1],
                    coordinateOfSwap[2], coordinateOfSwap[3]);
                }

                
            }
            else
            {
                Console.WriteLine("Invalid input");
                Console.WriteLine();
            }
            comand = Console.ReadLine();
        }
        
        
    }

    static void SwapElements(string[,] someMatrix,int matrixRow, int matrixCol, int pos1row, int pos1col, int pos2row, int pos2col)
    {
        string firstElement = string.Empty;
        string secondElement = string.Empty;

        firstElement = someMatrix[pos1row, pos1col];
        secondElement = someMatrix[pos2row, pos2col];

        someMatrix[pos2row, pos2col] = firstElement;
        someMatrix[pos1row, pos1col] = secondElement;

        for (int i = 0; i < matrixRow; i++)
        {
            for (int j = 0; j < matrixCol; j++)
            {
                Console.Write(someMatrix[i,j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

