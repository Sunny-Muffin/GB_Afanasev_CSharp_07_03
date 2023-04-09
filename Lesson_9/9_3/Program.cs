// Задача 3: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр. Использовать рекурсию

int num = GetUserNumber("number");
int sum = 0;
SumNumbers(num);
Console.WriteLine(sum);

int GetUserNumber(string name)
{
    int number = 0;
    Console.Write($"Please enter {name}: ");
    number = int.Parse(Console.ReadLine()!);
    return number;
}

void SumNumbers (int number)
{
    if (number % 10 == 0)
    {
        return;
    }
    SumNumbers (number / 10);
    sum += number%10;
}