// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях

int arrLength = 6; 
int arrMin = -99; 
int arrMax = 100; 

int[] arr = MakeArray(arrLength, arrMin, arrMax);
PrintArray (arr);
Console.WriteLine($"Sum of elements in odd posiitons: {SumOddElem(arr)}");

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

int SumOddElem(int[] array)
{
    int sum = 0;
    int len = array.Length;
    for (int i = 0; i < len; i+=2)
    {
        sum += array[i];
    }
    return sum;
}