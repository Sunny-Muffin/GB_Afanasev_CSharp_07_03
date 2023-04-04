// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии

int start = GetUserNumber("begin number");
int finish = GetUserNumber("end number");
Console.WriteLine(SumNumbers(start, finish));

int GetUserNumber(string name)
{
    int number = 0;
    Console.Write($"Please enter {name}: ");
    number = int.Parse(Console.ReadLine()!);
    return number;
}

int SumNumbers (int begin, int end)
{
    if (end < begin + 1)
    {
        return end;
    }
    return SumNumbers (begin, end - 1) + end;
}
