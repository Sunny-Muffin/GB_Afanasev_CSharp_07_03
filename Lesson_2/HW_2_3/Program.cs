// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// Поскольку я уже делал программу, которая выводит день недели по цифре, то возьму её, чисто технически соответствует заданию.

int dayNumber = GetDayNumber();
PrintDay(dayNumber, SelectDay(dayNumber));

int GetDayNumber()
{
    Console.Write("Please enter day of the week number n = ");
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

string SelectDay (int n)
{
    switch (n)
    {
        case 1:
            return "Monday";
        case 2:
            return "Tuesday";
        case 3:
            return "Wednesday";
        case 4:
            return "Thursday";
        case 5:
            return "Friday";
        case 6:
            return "Saturday (Weekend!)";
        case 7:
            return "Sunday (Weekend!)";
        default:
            return "No such day";
    }
}

void PrintDay (int dayNum, string dayText)
{
    Console.WriteLine($"{dayNum} -> {dayText}");
}
