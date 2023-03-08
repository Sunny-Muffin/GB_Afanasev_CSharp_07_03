// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)

Console.Write("Please enter number n = ");
int num = int.Parse(Console.ReadLine()!);

if (num % 2 == 0)
{
    Console.WriteLine($"Number {num} is EVEN");
}
else
{
    Console.WriteLine($"Number {num} is ODD");
}
