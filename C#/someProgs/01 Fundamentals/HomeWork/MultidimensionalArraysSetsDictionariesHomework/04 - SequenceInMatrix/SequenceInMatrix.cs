using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 



class SequenceInMatrix
{
    static void Main()
    {
        int[] matrixRowCol = new int[2];
        matrixRowCol[0] = int.Parse(Console.ReadLine());
        matrixRowCol[1] = int.Parse(Console.ReadLine());
        string[,] matrix = new string[matrixRowCol[0], matrixRowCol[1]];

        string[] input = Console.ReadLine().Split(' ').ToArray();


        // fill the matrix
        int index = 0;
        for (int i = 0; i < matrixRowCol[0]; i++)
        {
            for (int j = 0; j < matrixRowCol[1]; j++)
            {
                matrix[i, j] = input[index];
                index++;
            }
        }

        // fill dictionary -> elements and it's coordinates in matrix from Min. to Max.
        SortedDictionary<string, string> coordinatesOfStrings = new SortedDictionary<string, string>();
       
        for (int row = 0; row < matrixRowCol[0]; row++)
        {

            for (int col = 0; col < matrixRowCol[1]; col++)
            {
                if (!coordinatesOfStrings.ContainsKey(matrix[row,col]))
                {
                    coordinatesOfStrings.Add(matrix[row, col], string.Empty);
                }
                if (coordinatesOfStrings.ContainsKey(matrix[row,col]))
                {
                    coordinatesOfStrings[matrix[row, col]] = coordinatesOfStrings[matrix[row, col]] + "" + Convert.ToString(row) + " " + Convert.ToString(col) + " ";
                }
            }
        }

        int counter = 0;        // 
        int bestCounter = 0;    //
        string equalStrings = string.Empty; // name of element in a matrix
        int a = 0;  /// compare coordinates with A and B
        int b = 0;
        

        // 

        foreach (var key in coordinatesOfStrings)
        {
            counter = 0;

            bool abPlus = true; // check diagonal in matrix
            bool aPlus = true;  // check row in matrix
            bool bPlus = true;  // check column in matrix

            for (int i = 0; i < key.Value.Length - 1; i += 4)
            {

                if (i == 0)
                {
                    a = int.Parse(Convert.ToString(key.Value[i]));
                    b = int.Parse(Convert.ToString(key.Value[i + 2]));
                    counter++;
                    continue;
                }

                a++; // increase  A , B or AB to check current coordinates
                b++;

                if ((int.Parse(Convert.ToString(key.Value[i])) == a) &&
                    (int.Parse(Convert.ToString(key.Value[i + 2])) == b) && abPlus)
                {
                    counter++;
                    a = int.Parse(Convert.ToString(key.Value[i]));
                    b = int.Parse(Convert.ToString(key.Value[i + 2]));
                    aPlus = false; // disallow  check for other possibility 
                    bPlus = false;

                    if (counter > bestCounter)
                    {
                        bestCounter = counter;
                        equalStrings = key.Key;
                        
                    }
                    continue;
                }

                a--;   // return value to check this variant 

                if ((int.Parse(Convert.ToString(key.Value[i])) == a) &&
                    (int.Parse(Convert.ToString(key.Value[i + 2])) == b) && bPlus)
                {
                    counter++;
                    a = int.Parse(Convert.ToString(key.Value[i]));
                    b = int.Parse(Convert.ToString(key.Value[i + 2]));
                    abPlus = false;
                    aPlus = false;

                    if (counter > bestCounter)
                    {
                        bestCounter = counter;
                        equalStrings = key.Key;
                        
                    }
                    continue;
                }

                b--;
                a++;

                if ((int.Parse(Convert.ToString(key.Value[i])) == a) &&
                    (int.Parse(Convert.ToString(key.Value[i + 2])) == b) && aPlus)
                {
                    counter++;
                    a = int.Parse(Convert.ToString(key.Value[i]));
                    b = int.Parse(Convert.ToString(key.Value[i + 2]));
                    abPlus = false;
                    bPlus = false;

                    if (counter > bestCounter)
                    {
                        bestCounter = counter;
                        equalStrings = key.Key;
                        
                    }
                    continue;
                }
                a--;

                // if no equals ,take new coordinates
                a = int.Parse(Convert.ToString(key.Value[i]));
                b = int.Parse(Convert.ToString(key.Value[i + 2]));

                abPlus = true;
                aPlus = true;
                bPlus = true;

            }
        }
        Console.WriteLine(string.Join(", ", Enumerable.Repeat(equalStrings, bestCounter)));
        

        
        
    }
}

