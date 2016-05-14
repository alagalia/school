using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class test
{
    static void Main()
    {
        //string pathern = @"[0-9|0-9]+";
        //Regex match = new Regex(pathern);

        string a = "12|345";
        string b = "1|2345";

        //string[] aa = a.Split('|');
        //string[] bb = b.Split('|');

        //bool c = match.IsMatch(a) == match.IsMatch(b);
        Console.WriteLine(a.Replace("|","") == b.Replace("|", ""));
        Console.WriteLine(a+" "+b);
    }
}

