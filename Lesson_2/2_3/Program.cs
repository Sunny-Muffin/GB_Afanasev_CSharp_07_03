// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

//IsDividable(GenerateNumber());
IsDividable(GetNumber());

void IsDividable(int n)
{
    if(n % 7 == 0 && n % 23 == 0)
    {
        Console.WriteLine($"{n} can be divided by 7 and 23");
    }
    else
    {
        Console.WriteLine($"{n} can NOT be divided by 7 and 23");
    }
}

int GetNumber()
{
    Console.Write("Please enter number n = ");
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

int GenerateNumber()
{
    int number = new Random().Next(100, 10000);
    return number;
}


