// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве

int arrLength = 10; 
int arrMin = 100; 
int arrMax = 1000; 

int[] arr = MakeArray(arrLength, arrMin, arrMax);
PrintArray (arr);
Console.WriteLine($"There are {FindEven(arr)} even numbers");

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

int FindEven(int[] array)
{
    int count = 0;
    int len = array.Length;
    for (int i = 0; i < len; i++)
    {
        if(array[i]%2 == 0)
        {
            count++;
        }
    }
    return count;
}