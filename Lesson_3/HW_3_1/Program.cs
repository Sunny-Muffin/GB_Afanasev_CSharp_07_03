// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом

//int num = GenerateNumber();
int num = GetUserNumber();

if (IsPalindrom(num))
{
    Console.WriteLine($"Your number {num} is a palindrome");
}
else
{
    Console.WriteLine($"Your number {num} is NOT a palindrome");
}

int GenerateNumber()
{
    int number = new Random().Next(10000, 100000);
    return number;
}

int GetUserNumber()
{
    int number = 1;
    while ((number/10000) < 1 || (number/10000) > 9)
    {
        Console.Write("Please enter 5-digit number: ");
        number = int.Parse(Console.ReadLine()!);
    }
    return number;
}

// this function works only for 5-digit numbers
bool IsPalindrom(int number)
{
    int[]arr = new int[5];
    int count = arr.Length - 1;
    while(number > 0)
    {
        arr[count] = number%10;
        number/=10;
        count--;
    }

    if(arr[0] == arr[4] && arr[1] == arr[3])
    {
        return true;
    }
    return false;
}