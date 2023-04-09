// Задача 60. Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.

int arrRows = 4; 
int arrColumns = 3; 
int arrMin = 0; 
int arrMax = 9; 


int[,] arr = Make2DArray(arrRows, arrColumns, arrMin, arrMax);
Print2DArray(arr);
int[] minInd = FindMinIndexes(arr);
Console.WriteLine($"Minimum element is in [{minInd[0]}, {minInd[1]}]");
Print2DArray(MakeNewArray(arr,minInd));

int[] FindMinIndexes (int[,] array)
{
    int rows = array.GetUpperBound(0) + 1;
    int columns = array.Length / rows;
    int[] minIndexes = new int [2];
    int min = array[0,0];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (array[i,j] < min)
            {
                min = array[i,j];
                minIndexes[0] = i;
                minIndexes[1] = j;
            }
        }
    }
    return minIndexes;
}

// makes new array without row and column, that have minimum element
int[,] MakeNewArray(int[,] array, int[]indexes)
{
    int rows = array.GetUpperBound(0) + 1;
    int columns = array.Length / rows;
    int k = 0;
    int l = 0;

    int[,] newArray = new int[rows - 1, columns - 1];

    for(int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (i == indexes[0] || j == indexes[1])
            {
                continue;
            }
            else
            {
                newArray[k,l] = array[i,j];
                l++;
            }
        }
        l = 0;
        if (indexes[0] != i)
        {
            k++;
        }
    }
    return newArray;
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
