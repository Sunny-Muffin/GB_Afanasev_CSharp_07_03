// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце


int arrRows = 3; 
int arrColumns = 4; 
int arrMin = 0; 
int arrMax = 9; 


int[,] arr = Make2DArray(arrRows, arrColumns, arrMin, arrMax);
Print2DArray(arr);
FindMeanInEveryColumn(arr);


void FindMeanInEveryColumn (int[,] array)
{
    int rows = array.GetUpperBound(0) + 1;
    int columns = array.Length / rows;
    double sum = 0;

    for(int i = 0; i < columns; i++)
    {
        sum = 0;
        for (int j = 0; j < rows; j++)
        {
            sum += arr[j,i];
        }
        Console.WriteLine($"avg of column {i + 1}: {Math.Round(sum / rows, 2)} ");
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
