// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива

int arrRows = 4; 
int arrColumns = 3; 
int arrMin = 0; 
int arrMax = 9; 


int[,] arr = Make2DArray(arrRows, arrColumns, arrMin, arrMax);
Print2DArray(arr);
SelectionSort(arr);
Print2DArray(arr);


void SelectionSort (int[,] array)
{
    int rows = array.GetUpperBound(0) + 1;
    int columns = array.Length / rows;

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            int max = array[i,j];
            int kMax = j;
            for (int k = j + 1; k < columns; k++)
            {
                if (array[i,k] > max)
                {
                    kMax = k;
                    max = array[i,k];
                }
            }

        (array[i, j], array[i, kMax]) = (array[i, kMax], array[i, j]);

        }
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
