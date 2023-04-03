// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами

int arrRows = 4; 
int arrColumns = 3; 
int arrMin = -10; 
int arrMax = 10; 

double[,] arr = Make2DArray(arrRows, arrColumns, arrMin, arrMax);
Print2DArray(arr);

double[,] Make2DArray(int rows, int columns, int min, int max)
{
    double[,] arr = new double[rows, columns];

    for(int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            arr[i,j] = Math.Round(new Random().NextDouble() * (max - min) + min, 2);
        }
    }

    return arr;
}

void Print2DArray(double[,] array)
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
