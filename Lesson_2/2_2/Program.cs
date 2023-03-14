// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деление.

int num1 = GetNumber();
int num2 = GetNumber();
IsMultiple(num1, num2);

void IsMultiple(int n1, int n2)
{
    if(n1 % n2 == 0)
    {
        Console.WriteLine($"{n1} is multiple for {n2}");
    }
    else
    {
        Console.WriteLine($"{n1} % {n2} = {n1%n2}");
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
    int number = new Random().Next(1, 1000);
    return number;
}

