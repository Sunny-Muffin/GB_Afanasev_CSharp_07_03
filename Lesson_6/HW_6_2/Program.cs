// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем

double K1 = GetUserNumber("k1");
double B1 = GetUserNumber("b1");
double K2 = GetUserNumber("k2");
double B2 = GetUserNumber("b2");

FindCrossing(K1, B1, K2, B2);


double GetUserNumber(string name)
{
    double number = 0;
    Console.Write($"{name} = ");
    number = double.Parse(Console.ReadLine()!);
    return number;
}

void FindCrossing(double k1, double b1, double k2, double b2)
{
    /*
    y = k1 * x + b1, 
    y = k2 * x + b2

    k1*x + b1 = k2*x + b2  =>  x(k1 - k2) = b2 - b1  =>  x = (b2-b1)/(k1-k2)
    y = k1 * ((b2-b1)/(k1-k2)) + b1 || y = k2 * ((b2-b1)/(k1-k2)) + b2
    */

    if (k1 == k2 && b1 != b2)
    {
        Console.WriteLine("Lines are parallel");
    }
    else if (k1 == k2 && b1 == b2)
    {
        Console.WriteLine("Lines match");
    }
    else
    {
        if ((k1 == 0 && b2 == 0) || (k2 == 0 && b1 == 0))
        {
            Console.WriteLine("Lines are perpendicular");
        }
        double x = Math.Round(((b2 - b1) / (k1 - k2)), 2);
        double y = Math.Round((k1 * x + b1), 2);
        Console.WriteLine($"k1 = {k1}, b1 = {b1}, k2 = {k2}, b2 = {b2} -> ({x}; {y})");
    }
}
