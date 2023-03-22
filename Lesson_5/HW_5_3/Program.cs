// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива

int arrLength = 10; 
int arrMin = -99; 
int arrMax = 99; 

double[] arr = MakeArray(arrLength, arrMin, arrMax);
PrintArray (arr);
double maxElem = FindMax(arr);
double minElem = FindMin(arr);
Console.WriteLine($"Minimum element: {minElem}");
Console.WriteLine($"Maximum element: {maxElem}");
Console.WriteLine($"max - min = {maxElem - minElem}");

double[] MakeArray(int length, int min, int max)
{
    double[] arr = new double[length];
    for(int i = 0; i < length; i++)
    {
        arr[i] = Math.Round(new Random().NextDouble() * (max - min) + min, 2);
    }
    return arr;
}

void PrintArray(double[] array)
{
    int len = array.Length;
    for (int i = 0; i < len; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

double FindMax(double[] array)
{
    double max = array[0];
    int len = array.Length;
    for (int i = 0; i < len; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}

double FindMin(double[] array)
{
    double min = array[0];
    int len = array.Length;
    for (int i = 0; i < len; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}