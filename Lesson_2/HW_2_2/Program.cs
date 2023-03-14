// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет

int number = GenerateNumber();
if (MoreThanThreeDigits(number))
{
    PrintThirdDigit(number, GetThirdDigit(number));
}
else
{
    Console.WriteLine("NO third digit");
}


int GenerateNumber()
{
    int number = new Random().Next(1, 1000000);
    return number;
}

bool MoreThanThreeDigits(int n)
{
    return (n/100 > 0) ? true : false;
}

int GetThirdDigit(int n)
{
    return n / 100 % 10;
}

void PrintThirdDigit(int num, int third)
{
    Console.WriteLine($"Third digit of number {num} is {third}");
}
