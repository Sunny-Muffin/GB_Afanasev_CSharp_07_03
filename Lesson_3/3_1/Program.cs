﻿GetQuarter();

void GetQuarter ()
{
    Console.Write("Please enter quarter = ");
    int q = int.Parse(Console.ReadLine()!);
    if (q < 1 || q > 4)
    {
        Console.WriteLine("No such quarter");
    }
    else
    {
        switch(q)
        {
            case 1:
                Console.WriteLine("x > 0, y > 0");
                break;
            case 2:
                Console.WriteLine("x < 0, y > 0");
                break;
            case 3:
                Console.WriteLine("x < 0, y < 0");
                break;
            case 4:
                Console.WriteLine("x > 0, y < 0");
                break;
            default:
                Console.WriteLine("No such quarter");
                break;
        }
    }
}
