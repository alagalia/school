using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class FillTheMatrix
{
    static void Main()
    {
        /// zadachata e napravena za ROWS * COLS a ne N * N 
        int rows = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());

        int currentNum = 1;
        int startnum = 1;

        int[,] matrix = new int[rows, cols];


        // fill first matrix
        for (int i = 0; i < rows; i++)
        {
            currentNum = startnum;
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = currentNum;
                currentNum += rows;
                
            }
            startnum++;
           

        }

        PrintTheMatrix(matrix, rows, cols);

        Console.WriteLine();

        /// fill second matrix
        /// 
        currentNum = 1;
        startnum = 1;

        for (int i = 0; i < cols; i++)
        {
            
            for (int j = 0; j < rows; j++)
            {
                matrix[j, i] = currentNum;
                if (i % 2 == 0)
                {
                    currentNum++;
                }
                else
                {
                    currentNum--;
                }
            }

            if (i % 2 == 0)
            {
                currentNum += rows - 1;
            }
            else
            {
                currentNum += rows + 1;
            }

        }

        PrintTheMatrix(matrix, rows, cols);

        Console.WriteLine();

        

    }

    static void PrintTheMatrix(int[,] currentMatrix, int row, int col)
    {
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                Console.Write(currentMatrix[i,j] + " ");
            }
            Console.WriteLine();
        }
    }
}

