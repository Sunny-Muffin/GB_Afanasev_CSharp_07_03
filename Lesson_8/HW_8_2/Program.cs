// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов

int arrRows = 4; 
int arrColumns = 3; 
int arrMin = 0; 
int arrMax = 9; 


int[,] arr = Make2DArray(arrRows, arrColumns, arrMin, arrMax);
Print2DArray(arr);
int[] sumRows = SumRow(arr);
int minRow = FindMinIndexInArray(sumRows) + 1;
Console.WriteLine($"Row with minimum element sum is {minRow}");


int[] SumRow (int[,] array)
{
    int rows = array.GetUpperBound(0) + 1;
    int columns = array.Length / rows;
    int[] sum = new int [rows];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            sum[i] += array[i,j];
        }
    }
    return sum;
}

int FindMinIndexInArray (int[] array)
{
    int minIndex = 0;
    int minElem = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < minElem)
        {
            minElem = array[i];
            minIndex = i;
        }
    }
    return minIndex;
}

int[,] Make2DArray(int rows, int columns, int min, int max)
{
    int[,] arr = new int[rows, columns];

    for(int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            arr[i,j] = new Random().Next(min, max + 1);
        }
    }

    return arr;
}

void Print2DArray(int[,] array)
{
    int rows = array.GetUpperBound(0) + 1;
    int columns = array.Length / rows;

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}