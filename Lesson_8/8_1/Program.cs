// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя

int arrRows = 3; 
int arrColumns = 3; 
int arrMin = 1; 
int arrMax = 9; 

int[,] arr = Make2DArray(arrRows, arrColumns, arrMin, arrMax);
Print2DArray(arr);
ChangeRowsOnColumns(arr);
Print2DArray(arr);

void ChangeRowsOnColumns(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    if (rows == columns)
    {
        for (int i = 0; i < rows; ++i)
        {
            for(int j = 0; j < i; ++j)
            {
                (array[i, j], array[j, i]) = (array[j, i], array[i, j]);
            }
        }
    }
    else
    {
        Console.WriteLine("Cannot make changes");
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


