using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestAlphabeticalWord
{
    class LongestAlphabeticalWord
    {
        static void Main()
        {
            string text = Console.ReadLine();

            char[] letters = new char[text.Length];

            for (int i = 0; i < text.Length; i++)
            {
                letters[i] = text[i];
            }

            int size = int.Parse(Console.ReadLine());

            string word = string.Empty;
            string currentWord = string.Empty;
            int read = 0;
            int current = 0;

            char[,] matrix = new char[size, size];


            int letterIndex = 0;
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = letters[letterIndex];
                    letterIndex++;
                    if (letterIndex == letters.Length)
                    {
                        letterIndex = 0;
                    }
                    //Console.Write(matrix[row, col]);


                }
                // Console.WriteLine();
            }
            // from left to right -- up to down
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    read = (int)matrix[row, col];
                    //int current = 0;
                    if (read <= current)
                    {

                        current = read;
                        word = string.Empty;
                        word = word + matrix[row, col];
                    }
                    if (read > current)
                    {

                        //
                        word = word + matrix[row, col];

                    }
                    if ((read < word[0]))
                    {
                        current = read;
                        word = string.Empty;
                        word = word + matrix[row, col];
                    }

                    current = read;



                }
                if (word.Length >= currentWord.Length)
                {
                    if (word.Length > currentWord.Length)
                    {
                        currentWord = word;
                        word = string.Empty;
                        read = 0;
                        current = 0;

                    }
                    if ((word.Length == currentWord.Length) && (word != currentWord))
                    {
                        if ((int)word[0] <= (int)currentWord[0])
                        {
                            int a = 0;
                            int b = 0;
                            for (int i = 0; i < word.Length; i++)
                            {
                                a = (int)word[i];
                                b = (int)currentWord[i];
                                if (a < b)
                                {
                                    currentWord = word;
                                    word = string.Empty;
                                    read = 0;
                                    current = 0;

                                }
                                if (a == b)
                                {
                                    continue;
                                }
                                else
                                {
                                    word = string.Empty;
                                    read = 0;
                                    current = 0;
                                }
                            }

                        }

                    }
                    word = string.Empty;
                    read = 0;
                    current = 0;

                }
                word = string.Empty;
                read = 0;
                current = 0;
            }
            word = string.Empty;
            for (int row = 0; row < size; row++)
            {
                for (int col = size - 1; col >= 0; col--)
                {
                    read = (int)matrix[row, col];
                    //int current = 0;
                    if (read <= current)
                    {

                        current = read;
                        word = string.Empty;
                        word = word + matrix[row, col];
                    }
                    if (read > current)
                    {

                        //
                        word = word + matrix[row, col];

                    }
                    if (read < word[0])
                    {
                        current = read;
                        word = string.Empty;
                        word = word + matrix[row, col];
                    }

                    current = read;



                }
                if (word.Length >= currentWord.Length)
                {
                    if (word.Length > currentWord.Length)
                    {
                        currentWord = word;
                        word = string.Empty;
                        read = 0;
                        current = 0;

                    }
                    if ((word.Length == currentWord.Length) && (word != currentWord))
                    {
                        if ((int)word[0] <= (int)currentWord[0])
                        {
                            int a = 0;
                            int b = 0;
                            for (int i = 0; i < word.Length; i++)
                            {
                                a = (int)word[i];
                                b = (int)currentWord[i];
                                if (a < b)
                                {
                                    currentWord = word;
                                    word = string.Empty;
                                    read = 0;
                                    current = 0;

                                }
                                if (a == b)
                                {
                                    continue;
                                }
                                else
                                {
                                    word = string.Empty;
                                    read = 0;
                                    current = 0;
                                }
                            }

                        }

                    }
                    word = string.Empty;
                    read = 0;
                    current = 0;

                }
                word = string.Empty;
                read = 0;
                current = 0;
            }
            word = string.Empty;
            for (int col = 0; col < size; col++)
            {
                for (int row = 0; row < size; row++)
                {
                    read = (int)matrix[row, col];
                    //int current = 0;
                    if (read <= current)
                    {

                        current = read;
                        word = string.Empty;
                        word = word + matrix[row, col];
                    }
                    if (read > current)
                    {

                        //
                        word = word + matrix[row, col];

                    }
                    if ((read < word[0]))
                    {
                        current = read;
                        word = string.Empty;
                        word = word + matrix[row, col];
                    }

                    current = read;



                }
                if (word.Length >= currentWord.Length)
                {
                    if (word.Length > currentWord.Length)
                    {
                        currentWord = word;
                        word = string.Empty;
                        read = 0;
                        current = 0;

                    }
                    if ((word.Length == currentWord.Length) && (word != currentWord))
                    {
                        if ((int)word[0] <= (int)currentWord[0])
                        {
                            int a = 0;
                            int b = 0;
                            for (int i = 0; i < word.Length; i++)
                            {
                                a = (int)word[i];
                                b = (int)currentWord[i];
                                if (a < b)
                                {
                                    currentWord = word;
                                    word = string.Empty;
                                    read = 0;
                                    current = 0;

                                }
                                if (a == b)
                                {
                                    continue;
                                }
                                else
                                {
                                    word = string.Empty;
                                    read = 0;
                                    current = 0;
                                }
                            }

                        }

                    }
                    word = string.Empty;
                    read = 0;
                    current = 0;

                }
                word = string.Empty;
                read = 0;
                current = 0;
            }
            word = string.Empty;
            for (int col = 0; col < size; col++)
            {
                for (int row = size - 1; row >= 0; row--)
                {
                    read = (int)matrix[row, col];
                    //int current = 0;
                    if (read <= current)
                    {

                        current = read;
                        word = string.Empty;
                        word = word + matrix[row, col];
                    }
                    if (read > current)
                    {

                        //
                        word = word + matrix[row, col];

                    }
                    if (read < word[0])
                    {
                        current = read;
                        word = string.Empty;
                        word = word + matrix[row, col];
                    }

                    current = read;



                }
                if (word.Length >= currentWord.Length)
                {
                    if (word.Length > currentWord.Length)
                    {
                        currentWord = word;
                        word = string.Empty;
                        read = 0;
                        current = 0;

                    }
                    if ((word.Length == currentWord.Length) && (word != currentWord))
                    {
                        if ((int)word[0] <= (int)currentWord[0])
                        {
                            int a = 0;
                            int b = 0;
                            for (int i = 0; i < word.Length; i++)
                            {
                                a = (int)word[i];
                                b = (int)currentWord[i];
                                if (a < b)
                                {
                                    currentWord = word;
                                    word = string.Empty;
                                    read = 0;
                                    current = 0;

                                }
                                if (a == b)
                                {
                                    continue;
                                }
                                else
                                {
                                    word = string.Empty;
                                    read = 0;
                                    current = 0;
                                }
                            }

                        }

                    }
                    word = string.Empty;
                    read = 0;
                    current = 0;

                }
                word = string.Empty;
                read = 0;
                current = 0;
            }
            Console.WriteLine(currentWord);

        }
    }
}
