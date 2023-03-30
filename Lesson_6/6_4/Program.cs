// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования
// Выполнить это задание для ДВУМЕРНОГО массива

int arrRows = 4; 
int arrColumns = 3; 
int arrMin = 1; 
int arrMax = 10; 

int[,] arr = Make2DArray(arrRows, arrColumns, arrMin, arrMax);
Print2DArray(arr);
int[,] newArr = Copy2DArray(arr);
Print2DArray(newArr);

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

int[,] Copy2DArray(int[,] array)
{
    int rows = array.GetUpperBound(0) + 1;
    int columns = array.Length / rows;
    int[,] newArray = new int[rows, columns];

    for(int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArray[i,j] = arr[i,j];
        }
    }

    return newArray;
}

