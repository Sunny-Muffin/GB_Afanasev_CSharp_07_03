// Задача 4: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии

int num = GetUserNumber("number");
int degree = GetUserNumber("power");
Console.WriteLine(ToThePower (num, degree));

int GetUserNumber(string name)
{
    int number = 0;
    Console.Write($"Please enter {name}: ");
    number = int.Parse(Console.ReadLine()!);
    return number;
}

int ToThePower (int number, int power)
{
    if (power == 1)
    {
        return number;
    }
    return ToThePower (number, power - 1) * number;
}