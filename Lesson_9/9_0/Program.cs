// Задача 1: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N при помощи рекурсии


int num = GetUserNumber("number");
PrintNumber (num);

int GetUserNumber(string name)
{
    int number = 0;
    Console.Write($"Please enter {name}: ");
    number = int.Parse(Console.ReadLine()!);
    return number;
}

void PrintNumber (int number)
{
    if (number < 1)
    {
        
        return;
    }
    PrintNumber (number - 1);
    Console.Write($"{number}  ");
    //Console.WriteLine();
}
