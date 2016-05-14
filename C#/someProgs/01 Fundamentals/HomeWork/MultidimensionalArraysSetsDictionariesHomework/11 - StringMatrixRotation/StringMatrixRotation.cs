using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class StringMatrixRotation
{
    static void Main()
    {
        string[] rotation = Console.ReadLine().Split(new char[] {'(',')'},StringSplitOptions.None);

        int degree = int.Parse(rotation[1]);
        if (degree > 360)
        {
            for (int i = degree; i >= 360; i -= 360)
            {
                degree -= 360;
                //if (degree == 90)
                //{
                //    degree = 270;
                //}
                //if (degree == 270)
                //{
                //    degree = 90;
                //}
            }
        }

        List<string> matrix = new List<string>();

        string input = Console.ReadLine();

        int maxLenght = 0;

        while (input != "END")
        {
            //input = input.Trim();

            if (input.Length > maxLenght)
            {
                maxLenght = input.Length;
            }
            matrix.Add(input);

            input = Console.ReadLine();
        }

        for (int i = 0; i < matrix.Count; i++)
        {
            int padding = maxLenght - matrix[i].Length;

            if (padding > 0)
            {
                matrix[i] = matrix[i] + new string(' ', padding);
            }
            
        }
        if (degree == 360 || degree == 0)
        {
            Rotate360(matrix, maxLenght);
        }
        else if (degree == 270)
        {
            Rotate270(matrix, maxLenght);
        }
        else if (degree == 180)
        {
            Rotate180(matrix, maxLenght);
        }
        else
        {
            Rotate90(matrix, maxLenght);
        }
        
        
        

    }
    static void Rotate90(List<string>matrix, int maxLenght)
    {
        for (int col = 0 ; col < maxLenght; col++)
        {
            for (int row = matrix.Count - 1; row >= 0; row--)
            {
                Console.Write(matrix[row].ElementAt(col));
            }
            Console.WriteLine();
        }
    }
    static void Rotate180(List<string> matrix, int maxLenght)
    {
        for (int row = matrix.Count - 1; row >= 0; row--)
        {
            for (int col = maxLenght - 1; col >= 0; col--)
            {
                Console.Write(matrix[row].ElementAt(col));
            }
            Console.WriteLine();
        }
    }
    static void Rotate270(List<string> matrix, int maxLenght)
    {
        for (int col = maxLenght -1 ; col >= 0 ; col--)
        {
            for (int row = 0; row < matrix.Count; row++)
            {
                Console.Write(matrix[row].ElementAt(col));
            }
            Console.WriteLine();
        }
    }
    static void Rotate360(List<string> matrix, int maxLenght)
    {
        for (int i = 0; i < matrix.Count; i++)
        {
            for (int j = 0; j < maxLenght; j++)
            {
                Console.Write(matrix[i].ElementAt(j));
            }
            Console.WriteLine();
        }
    }
}

