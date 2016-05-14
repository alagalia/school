using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class TerroristsWin
{
    static void Main()
    {
        string input = Console.ReadLine();

        int bombPower = 0;
        List<int> bombRadius = new List<int>();
        bool bomb = false;
        int jjIndex = 0;

        for (int i = 0; i < input.Length; i++)
        {
            if (bomb && (input[i] != '|'))
            {
                bombPower += (int)input[i];
            }
            if (input[i] == '|')
            {
                bombRadius.Add(i);
                if (bomb == false)
                {
                    bomb = true;
                }
                else
                {
                    bomb = false;

                    if (bombPower > 9)
                    {
                        bombPower = bombPower % 10;
                    }
                                        
                    for (int j = jjIndex; j < bombRadius.Count; jjIndex++,j++)
                    {
                        if (j % 2 == 0)
                        {
                            bombRadius[j] = bombRadius[j] - bombPower;
                            if (bombRadius[j] < 0)
                            {
                                bombRadius[j] = 0;
                            }
                        }
                        else
                        {
                            bombRadius[j] = bombRadius[j] + bombPower;
                            if (bombRadius[j] > input.Length - 1)
                            {
                                bombRadius[j] = input.Length - 1;
                            }
                        }
                        //jjIndex++;
                    }
                    bombPower = 0;
                }
                
            }
        }

        

        for (int i = 0; i < bombRadius.Count - 1; i += 2)
        {
            int start = bombRadius[i];
            int end = bombRadius[i + 1];
            string afterBomb = string.Empty;

            for (int j = 0; j < input.Length; j++)
            {
                
                if (j >= start && j <= end)
                {
                    afterBomb = afterBomb + ".";
                }
                else
                {
                    afterBomb = afterBomb + input[j];
                }
                
            }
            input = afterBomb;
            
        }
        Console.WriteLine(input);

        
    }
}

