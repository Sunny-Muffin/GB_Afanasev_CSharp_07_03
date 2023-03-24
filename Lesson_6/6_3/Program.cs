// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1

int num = GetUserNumber("number");
PrintFibonacci(num);

int GetUserNumber(string name)
{
    int number = 0;
    Console.Write($"Please enter {name}: ");
    number = int.Parse(Console.ReadLine()!);
    return number;
}

void PrintFibonacci(int number)
{
    int a = 0;
    int b = 1;
    Console.Write($"{a}, {b}");
    for (int i = 2; i < number; i++)
    {
        Console.Write($", {a + b}");
        (a,b) = (b,a+b);
    }
}

