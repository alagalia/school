using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class LegoBlocks
{
    static void Main()
    {
        int numOfRows = int.Parse(Console.ReadLine());

        int[][] firstMatrix = new int[numOfRows][];
        int[][] secondMatrix = new int[numOfRows][];

        FillTheMatrix(firstMatrix, numOfRows);
        FillTheMatrix(secondMatrix, numOfRows);

        int matrixLenght = 0;
        int supMatrixLenght = 0;
        bool areEqual = true;
        int counter = 0;

        for (int i = 0; i < numOfRows; i++)
        {
            supMatrixLenght = firstMatrix[i].GetLength(0) + secondMatrix[i].GetLength(0);
            counter += supMatrixLenght;

            if (i == 0)
            {
                matrixLenght = supMatrixLenght;
            }
            else
            {
                if (matrixLenght != supMatrixLenght)
                {
                    areEqual = false;
                    
                }
            }
        }

        
        if (areEqual)
        {
            ReverseTheSecondMatrix(secondMatrix, numOfRows);
            MergedMatrix(firstMatrix, secondMatrix, numOfRows);
        }
        else
        {
            Console.WriteLine("The total number of cells is: {0}", counter);
        }



    }

    static void FillTheMatrix(int [][] matrix, int lenght)
    {
        for (int i = 0; i < lenght; i++)
        {
            matrix[i] = Console.ReadLine().Split(new []{' '},StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        }
    }
    static void ReverseTheSecondMatrix (int [] [] matrix, int lenght)
    {
        for (int i = 0; i < lenght; i++)
        {
            Array.Reverse(matrix[i]);
        }
    }
    static void MergedMatrix(int [][] matrix,int [][] matrix1, int lenght)
    {
        for (int i = 0; i < lenght; i++)
        {
            Console.Write("[");
            for (int j = 0; j < matrix[i].GetLength(0); j++)
            {
                Console.Write(matrix[i][j] + ", ");
                if (j == matrix[i].GetLength(0) - 1 )
                {
                    for (int k = 0; k < matrix1[i].GetLength(0); k++)
                    {
                        if (k == matrix1[i].GetLength(0) - 1)
                        {
                            Console.Write(matrix1[i][k]);
                        }
                        else
                        {
                            Console.Write(matrix1[i][k] + ", ");
                        }
                        
                    }
                }
                
            }
            Console.Write("]");
            Console.WriteLine();
        }
    }
}

