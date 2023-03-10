int num = GenerateNumber();
PrintLastDigit(num);


int GetNumber()
{
    Console.Write("Please enter number n = ");
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

int GenerateNumber()
{
    int number = new Random().Next(100, 1000);
    return number;
}

void PrintLastDigit (int n)
{
    Console.WriteLine($"Last digit of number {n} is {n%10}");
}

