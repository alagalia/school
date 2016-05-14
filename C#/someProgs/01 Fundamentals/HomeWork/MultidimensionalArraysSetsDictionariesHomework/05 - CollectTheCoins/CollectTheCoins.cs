using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CollectTheCoins
{
    static void Main()
    {
        char[][] matrix = new char[4][];

        for (int i = 0; i < 4; i++)
        {
            char[] input = Console.ReadLine().ToArray();
            matrix[i] = new char[input.Length];

            for (int j = 0; j < matrix[i].Length; j++)
            {
                matrix[i][j] = input[j];
            }
        }
        //Console.WriteLine(matrix[0].Length);

        //for (int i = 0; i < 4; i++)
        //{
        //    for (int j = 0; j < matrix[i].Length; j++)
        //    {
        //        Console.Write(matrix[i][j]);
        //    }
        //    Console.WriteLine();
        //}
        string movement = Console.ReadLine();

        int row = 0;
        int col = 0;
        int wallHits = 0;
        int coins = 0;

        for (int i = 0; i < movement.Length; i++)
        {
            char currentChar = movement[i];

            if (matrix[row][col] == '$')
            {
                coins++;
            }
            
            switch (currentChar)
            {
                case 'V': row += 1;
                    if (row > 3 || (col > matrix[row].Length - 1 || col < 0))
                    {
                        row -= 1;
                        wallHits++;
                    }
                    break;
                case '^': row -= 1;
                    if (row < 0 || (col > matrix[row].Length - 1 || col < 0))
                    {
                        row += 1;
                        wallHits++;
                    }
                    break;
                case '<': col -= 1;
                    if (col < 0)
                    {
                        col += 1;
                        wallHits++;
                    }
                    break;
                case '>': col += 1;
                    if (col > matrix[row].Length - 1 )
                    {
                        col -= 1;
                        wallHits++;
                    }
                    break;
            }

            

        }
        Console.WriteLine("Coins collected: {0}", coins);
        Console.WriteLine("Walls hit: {0}", wallHits);

    }
}

