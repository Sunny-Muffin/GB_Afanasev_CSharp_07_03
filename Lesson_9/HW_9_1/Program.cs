// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии

int start = GetUserNumber("begin number");
int finish = GetUserNumber("end number");
PrintEvenNumbers (start, finish);
Console.WriteLine();

int GetUserNumber(string name)
{
    int number = 0;
    Console.Write($"Please enter {name}: ");
    number = int.Parse(Console.ReadLine()!);
    return number;
}

void PrintEvenNumbers (int begin, int end)
{
    if (end % 2 != 0)
    {
        end--;
    }
    
    if (end < begin)
    {
        return;
    }
    PrintEvenNumbers (begin, end - 2);
    Console.Write($"{end}  ");
}