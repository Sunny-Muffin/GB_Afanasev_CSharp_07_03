// Задача 3: Задайте двумерный массив. Найдите сумму элементов главной диагонали

int arrRows = 5; 
int arrColumns = 5; 
int arrMin = 0; 
int arrMax = 9; 

int[,] arr = Make2DArray(arrRows, arrColumns, arrMin, arrMax);
Print2DArray(arr);
Console.WriteLine($"Sum of main diagonal elements: {SumMainDiagonal(arr)}");

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

int SumMainDiagonal(int[,] array)
{
    int rows = array.GetUpperBound(0) + 1;
    int columns = array.Length / rows;
    int min = 0;
    int sum = 0;

    if (rows > columns)
    {
        min = columns;
    }
    else
    {
        min = rows;
    }

    for (int i = 0; i < min; i++)
    {
        sum += array[i,i];
    }
    return sum;
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