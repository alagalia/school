using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T07BalancedParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (input.Length % 2 != 0 || input.Length == 0 || input.Length > 1000)
            {
                Console.WriteLine("NO");
            }
            else
            {
                Stack<char> brackets = new Stack<char>();

                for (int i = 0; i < input.Length; i++)
                {
                    char current = input[i];
                    char support = '.';

                    if (brackets.Count() == 0)
                    {
                        brackets.Push(current);
                    }
                    else
                    {
                        //vkarva / in 
                        if (current == '[' || current == '(' || current == '{')
                        {
                            brackets.Push(current);
                        }
                        else /// izkarva / out
                        {
                            char last = brackets.First();

                            if (current == ')')
                            {
                                support = '(';
                            }
                            if (current == ']')
                            {
                                support = '[';
                            }
                            if (current == '}')
                            {
                                support = '{';
                            }
                            if (last == support)
                            {
                                brackets.Pop();
                            }
                            else
                            {
                                brackets.Push(current);
                            }
                        }
                        
                    }
                    
                }
                
                if (brackets.Count() == 0)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
        }
    }
}
