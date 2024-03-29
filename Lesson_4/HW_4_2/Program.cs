﻿// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе

int num = GetUserNumber();
int sum = SumNumbers(num);
Console.WriteLine($"{num} -> {sum}");

int GetUserNumber()
{
    int number = 0;
    Console.Write("Please enter number: ");
    number = int.Parse(Console.ReadLine()!);
    return number;
}

int SumNumbers(int n)
{
    int sum = 0;
    if (n < 0)
    {
        n = -n;
    }
    while (n > 0)
    {
        sum += n%10;
        n = n/10; 
    }
    return sum;
}

