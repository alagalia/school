using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class PlusRemove
{
    static void Main()
    {
        List<string> input = new List<string>();
        string inputLine = Console.ReadLine();

        while (inputLine != "END")
        {
            input.Add(inputLine);

            inputLine = Console.ReadLine();
        }

        int lines = input.Count;
        char[][] jaggedArr = new char[lines][];

        for (int row = 0; row < lines; row++)
        {                       
            jaggedArr[row] = input[row].ToLower().ToArray();           
        }

        SortedDictionary<int, List<int>> coordinates = new SortedDictionary<int, List<int>>();

        for (int row = 0; row < lines; row++)
        {
            for (int col = 0; col < jaggedArr[row].Length; col++)
            {
                bool firstCheck = col - 1 >= 0 && row - 1 >= 0 && row + 1 < input.Count;
                bool secondCheck = false;
                if (firstCheck)
	                {
                        secondCheck = (col < jaggedArr[row - 1].Length) &&
                            (col + 1 < jaggedArr[row].Length) &&
                            (col  < jaggedArr[row + 1].Length);
	                }

                bool inMatrix = firstCheck && secondCheck;

                if (inMatrix)
                {
                    //main = jaggedArr[row][col];
                    //mainUp = jaggedArr[row - 1][col];
                    //mainDown = jaggedArr[row + 1][col];
                    //mainLeft = jaggedArr[row][col - 1];
                    //mainRight = jaggedArr[row][col + 1];
                    if ((jaggedArr[row][col] == jaggedArr[row - 1][col]) && (jaggedArr[row][col] == jaggedArr[row + 1][col]) &&
                        (jaggedArr[row][col] == jaggedArr[row][col - 1]) && (jaggedArr[row][col] == jaggedArr[row][col + 1]))
                    {
                        
                        if (coordinates.ContainsKey(row - 1))
                        {
                            if (!coordinates[row - 1].Contains(col))
                            {
                                coordinates[row - 1].Add(col);
                            }
                            else
                            {
                                //continue;
                            }
                        }
                        if (coordinates.ContainsKey(row))
                        {
                            if (!coordinates[row].Contains(col - 1))
                            {
                                coordinates[row].Add(col - 1);
                            }
                            else
                            {
                                //continue;
                            }
                            if (!coordinates[row].Contains(col))
                            {
                                coordinates[row].Add(col);
                            }
                            else
                            {
                                //continue;
                            }
                            if (!coordinates[row].Contains(col + 1))
                            {
                                coordinates[row].Add(col + 1);
                            }
                            else
                            {
                                //continue;
                            }
                        }
                        if (coordinates.ContainsKey(row + 1))
                        {
                            if (!coordinates[row + 1].Contains(col))
                            {
                                coordinates[row + 1].Add(col);
                            }
                            else
                            {
                                //continue;
                            }
                        }
                        if (!coordinates.ContainsKey(row - 1))
                        {
                            List<int> colIndex = new List<int> { col };
                            coordinates.Add(row - 1, colIndex);
                        }
                        if (!coordinates.ContainsKey(row))
                        {
                            List<int> colIndex = new List<int> { col - 1, col, col + 1 };
                            coordinates.Add(row, colIndex);
                        }
                        if (!coordinates.ContainsKey(row + 1))
                        {
                            List<int> colIndex = new List<int> { col };
                            coordinates.Add(row + 1, colIndex);
                        }
                    }
                }

            }
        }
        for (int row = 0; row < lines; row++)
        {
            for (int col = 0; col < jaggedArr[row].Length; col++)
            {
                if (coordinates.ContainsKey(row))
                {
                    if (!coordinates[row].Contains(col))
                    {
                        //Console.Write(jaggedArr[row][col]);
                        Console.Write(input[row].ElementAt(col));
                    }
                }
                else
                {
                    //Console.Write(jaggedArr[row][col]);
                    Console.Write(input[row].ElementAt(col));
                }
                
                
            }
            Console.WriteLine();
        }

        
    }
}

