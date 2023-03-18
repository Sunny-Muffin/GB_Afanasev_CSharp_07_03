// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран
// Переделал задачу под N элементов, так универсальнее и интереснее

int arrLength = GetUserNumber("array length");
int arrMin = GetUserNumber("min element");
int arrMax = GetUserNumber("max element");

PrintArray (MakeArray(arrLength, arrMin, arrMax));

int GetUserNumber(string name)
{
    int number = 0;
    Console.Write($"Please enter {name}: ");
    number = int.Parse(Console.ReadLine()!);
    return number;
}

int[] MakeArray(int length, int min, int max)
{
    int[] arr = new int[length];
    for(int i = 0; i < length; i++)
    {
        arr[i] = new Random().Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] array)
{
    int len = array.Length;
    for (int i = 0; i < len; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
