// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа
// На сайте этого задания не было, но в методичке есть, на всякий случай выполнил

int num = GenerateNumber();
PrintDoubleDigitNumber (num, CreateDoubleDigitNumber(GetFirstDigit(num), GetLastDigit(num)));

int GenerateNumber()
{
    int number = new Random().Next(100, 1000);
    return number;
}

int GetFirstDigit(int n)
{
    return n / 100;
}

int GetLastDigit(int n)
{
    return n % 10;
}

int CreateDoubleDigitNumber(int numFirst, int numLast)
{
    return numFirst * 10 + numLast;
}

void PrintDoubleDigitNumber (int initNum, int doubleDigNum)
{
    Console.WriteLine($"{initNum} -> {doubleDigNum}");
}