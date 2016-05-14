using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security;

namespace TextGravity
{
    class TextGravity
    {
        static void Main()
        {
            // 57 
            int cols = int.Parse(Console.ReadLine());
            string inputText = Console.ReadLine();

            int remainder = inputText.Length % cols;

            int rows = 0;
            if (remainder == 0)
            {
                rows = inputText.Length / cols;
            }
            else
            {
                rows = (inputText.Length + cols - remainder) / cols;
            }
            
            inputText = inputText + new string(' ', cols - remainder);

            char[,] matrix = new char[rows,cols];

            int index = 0;
            for (int iRow = 0; iRow < rows; iRow++)
            {
                for (int jCols = 0; jCols < cols; jCols++)
                {
                    matrix[iRow, jCols] = inputText[index];
                    //Console.Write(matrix[iRow, jCols]);
                    index++;
                }
                //Console.WriteLine();
            }

            for (int col = 0; col < cols; col++)
            {
                StringBuilder colFromMatrix = new StringBuilder();
                StringBuilder arrangeColFromMatrix = new StringBuilder();
                int colFromMatrixLength = 0;

                for (int row = rows-1; row >= 0; row--)
                {
                    colFromMatrix.Append(matrix[row, col]);                    
                }

                colFromMatrixLength = colFromMatrix.Length;

                var result = from ch in colFromMatrix.ToString()
                          where ch != ' '
                          select ch;

                foreach (var ch in result)
                {
                    arrangeColFromMatrix.Append(ch);
                }
                for (int row1 = rows - 1; row1 >= 0; row1--)
                {
                    //arrangeColFromMatrix = arrangeColFromMatrix.ToString();

                    if (rows - 1 - row1 <= arrangeColFromMatrix.Length - 1)
                    {
                        matrix[row1, col] = arrangeColFromMatrix[rows - 1 - row1];
                    }
                    else
                    {
                        matrix[row1, col] = ' ';
                    }
                    
                }
            }
            //for (int i = 0; i < rows; i++)     ///// print matrix 
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        Console.Write(matrix[i,j]);
            //    }
            //    Console.WriteLine();
            //}
            StringBuilder finalResult = new StringBuilder();

            finalResult.Append("<table>");
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (col == 0 )
                    {
                        string support = "<tr>";
                        finalResult.Append(support);
                    }
                    string ch = string.Empty;
                    if (matrix[row, col] != ' ')
                    {
                        ch = SecurityElement.Escape(matrix[row, col].ToString());
                        string support = "<td>" + ch + "</td>";
                        finalResult.Append(support);
                    }
                    else
                    {
                        ch = matrix[row, col].ToString();
                        string support = "<td>" + ch + "</td>";
                        finalResult.Append(support);
                    }
                     
                    if (col == cols - 1)
                    {
                        string support = "</tr>";
                        finalResult.Append(support);
                    }
                }
            }
            finalResult.Append("</table>");

            Console.WriteLine(finalResult.ToString());
            
            

        }
    }
}
