// Задача 2: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве

int arrLength = GetUserNumber("array length");
int arrMin = GetUserNumber("min element");
int arrMax = GetUserNumber("max element");

int[] arr = MakeArray(arrLength, arrMin, arrMax);
PrintArray (arr);

int searched = GetUserNumber("searched number");
if (FindNumber(arr, searched))
{
    Console.WriteLine("Found");
}
else
{
    Console.WriteLine("NOT found");
}

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

bool FindNumber(int[] array, int n)
{
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] == n)
        {
            return true;
        }
    }
    return false;
}