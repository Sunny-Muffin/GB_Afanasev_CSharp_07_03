// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива

int arrRows = 5; 
int arrColumns = 5; 
int arrMin = 1; 
int arrMax = 10; 

int[,] arr = Make2DArray(arrRows, arrColumns, arrMin, arrMax);
Print2DArray(arr);
ChangeRows(arr);
Print2DArray(arr);

void ChangeRows(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    for (int i = 0; i < columns; ++i)
    {
        (array[0, i], array[rows - 1, i]) = (array[rows - 1, i], array[0, i]);
    }
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

