// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа

int number = GenerateNumber();
PrintMiddleDigit(number, GetMiddleDigit(number));

int GenerateNumber()
{
    int number = new Random().Next(100, 1000);
    return number;
}

int GetMiddleDigit(int n)
{
    return n / 10 % 10;
}

void PrintMiddleDigit(int num, int mid)
{
    Console.WriteLine($"Middle digit of number {num} is {mid}");
}

