using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Cinema
{
    static void Main()
    {
        string typeOfProjection = Console.ReadLine();
        int rows = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());
        decimal costOfTicket = 0M;

        switch (typeOfProjection)
        {
            case "Premiere": costOfTicket = 12M;
                break;
            case "Normal": costOfTicket = 7.5M;
                break;
            case "Discount": costOfTicket = 5M;
                break;
        }
        decimal income = costOfTicket * rows * cols;
        Console.WriteLine("{0:F2} leva", income);
    }
}

