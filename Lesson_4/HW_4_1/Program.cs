// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B

int num = GetUserNumber("number");
int pow = GetUserNumber("power");

Console.WriteLine($"{num}^{pow} = {ToThePower(num, pow)}");

int GetUserNumber(string name)
{
    int number = 0;
    Console.Write($"Please enter {name}: ");
    number = int.Parse(Console.ReadLine()!);
    return number;
}

double ToThePower(int n, int p)
{
    double newNum = 1;
    if(p > 0)
    {
        for (int i = 0; i < p; ++i)
        {
            newNum *= n;
        }
    }
    else if (p < 0)
    {
        for (int i = 0; i > p; --i)
        {
            newNum /= n;
        }
    }
    return Math.Round(newNum, 4);
}

