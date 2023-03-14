int num1 = int.Parse(Console.ReadLine()!);
int num2 = int.Parse(Console.ReadLine()!);

PrintQuarter(num1, num2);

void PrintQuarter (int x, int y)
{
    if (x > 0)
    {
        if (y > 0)
        {
            Console.WriteLine("1st quarter");
        }
        else if (y < 0)
        {
            Console.WriteLine("4th quarter");
        }
        else
        {
            Console.WriteLine("y must not be equal to 0");
        }
    }
    else if(x < 0)
    {
        if (y > 0)
        {
            Console.WriteLine("2nd quarter");
        }
        else if (y < 0)
        {
            Console.WriteLine("3rd quarter");
        }
        else
        {
            Console.WriteLine("y must not be equal to 0");
        }
    }
    else
    {
        Console.WriteLine("x must not be equal to 0");
    }
}