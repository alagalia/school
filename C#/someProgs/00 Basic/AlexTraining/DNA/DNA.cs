using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNA
{
    class DNA
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            string firstLetter = Console.ReadLine();

            int index = 0;
           
            switch (firstLetter)
            {
                case "A": index = 65;
                    break;
                case "B": index = 66;
                    break;
                case "C": index = 67;
                    break;
                case "D": index = 68;
                    break;
                case "E": index = 69;
                    break;
                case "F": index = 70;
                    break;
                case "G": index = 71;
                    break;
            }
            int index1 = 0;
            int index2 = 0;
            bool aa = false;
            int a = 1;
            int b = 0;
            int c = 0;
            int d = 0;

            for (int i = 0; i < num; i++)
            {
                if (i != 0)
                {
                    index = index2;
                }
                
                index1 = index;
                
                if (d < 3)
                {
                    a = 3;
                    a = a - d;
                }
                if (d == 3)
                {
                    a = 0;
                }
                if (d > 3)
                {
                    a = 1 + b;
                    b++; 
                }
                
                
                for (int j = 0; j < 7; j++)
                {
                    

                    if (a > 0 )
                    {
                        index = 46;
                        
                        
                        
                    }
                    if (j < 3 && d != 3)
                    {
                        c = a;
                        a--;
                    }
                    if (j >= 3 && d != 3)
                    {
                        c = a;
                        a++;
                    }
                    if (c <= 0 || d == 3)
                    {
                        index = index1;
                        index1++;
                        aa = true;
                        if (aa)
                        {
                            if (index1 == 72)
                            {
                                index1 = 65;
                            }
                            index2 = index1; 
                        }
                        
                    }
                    Console.Write("{0}", (char)index);
                    aa = false;

                    //index++;

                    

                    

                    

                }
                Console.WriteLine();
                index1--;
                d++;
                if (d == 7)
                {
                    d = 0;
                    b = 0;
                }
                    
                    
            }
            
        }
    }
}
