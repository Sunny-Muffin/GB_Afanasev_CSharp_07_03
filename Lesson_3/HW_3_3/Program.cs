// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N

PrintCubesOfNum(GetUserNumber());

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

void PrintCubesOfNum(int number)
{
    if(number > 0)
    {
        Console.Write(number + " -> 1");
        for (int i = 2; i <= number; ++i)
        {
            Console.Write(", " + i*i*i);
        }
    }
    else
    {
        Console.Write(number + " -> -1");
        for (int i = -2; i >= number; --i)
        {
            Console.Write(", " + i*i*i);
        }
    }
    Console.WriteLine();
}

