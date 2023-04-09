// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц

int arrRows1 = 3; 
int arrColumns1 = 2; 
int arrMin1 = 0; 
int arrMax1 = 9; 

int arrRows2 = 2; 
int arrColumns2 = 3; 
int arrMin2 = 0; 
int arrMax2 = 9; 


int[,] arr1 = Make2DArray(arrRows1, arrColumns1, arrMin1, arrMax1);
Print2DArray(arr1);
int[,] arr2 = Make2DArray(arrRows2, arrColumns2, arrMin2, arrMax2);
Print2DArray(arr2);

int[,] mult = MultiplyMatrices(arr1, arr2);
Print2DArray(mult);

int[,] MultiplyMatrices (int[,] array1, int[,] array2)
{
    int rows1 = array1.GetUpperBound(0) + 1;
    int columns1 = array1.Length / rows1;

    int rows2 = array2.GetUpperBound(0) + 1;
    int columns2 = array2.Length / rows2;

    int [,] multiplicationResult = new int [rows1, columns2];

    if (columns1 != rows2)
    {
        Console.WriteLine("This matrices cannot be multipled");
        return multiplicationResult;
    }

    for (int i = 0; i < rows1; i++)
    {
        for (int j = 0; j < columns2; j++)
        {
            for (int k = 0; k < columns1; k++)
            {
                multiplicationResult[i,j] += array1[i,k] * array2[k,j]; 
            }
        }
    }
    return multiplicationResult;
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