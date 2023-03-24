// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

int side1 = GetUserNumber("1st side");
int side2 = GetUserNumber("2nd side");
int side3 = GetUserNumber("3rd side");

IsTriangle(side1, side2, side3);

int GetUserNumber(string name)
{
    int number = 0;
    Console.Write($"Please enter {name}: ");
    number = int.Parse(Console.ReadLine()!);
    return number;
}

void IsTriangle (int a, int b, int c)
{
    if (a+b>c && a+c>b && c+b>a)
    {
        Console.WriteLine("Yes");
    }
    else
    {
        Console.WriteLine("No");
    }
}