// Задача 1: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

int num = GetUserNumber();
Console.WriteLine($"{num} -> {SumNumbers(num)}");

int GetUserNumber()
{
    int number = 0;
    while(number == 0)
    {
        Console.Write("Please enter number: ");
        number = int.Parse(Console.ReadLine()!);
    }
    return number;
}

int SumNumbers(int n)
{
    int sum = 0;
    for (int i = 1; i <= n; ++i)
    {
        sum += i;
    }
    return sum;
}
