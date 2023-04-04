// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

int arrRows = 5; 
int arrColumns = 5; 
int arrMin = 0; 
int arrMax = 9; 


int[,] arr = Make2DArray(arrRows, arrColumns, arrMin, arrMax);
Print2DArray(arr);
int row = GetUserNumber("row index");
int column = GetUserNumber("column index");
FindElementByIndexes(arr, row, column);


void FindElementByIndexes (int[,] array, int r, int c)
{
    int rows = array.GetUpperBound(0) + 1;
    int columns = array.Length / rows;
    if (r > 0 && r < rows+1 && c > 0 && c < columns+1)
    {
        Console.WriteLine($"array[{r},{c}] = {array[r-1,c-1]}");
    }
    else
    {
        Console.WriteLine($"Element [{r},{c}] does not exist");
    }
}

int GetUserNumber(string name)
{
    int number = 0;
    Console.Write($"Please enter {name}: ");
    number = int.Parse(Console.ReadLine()!);
    return number;
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
