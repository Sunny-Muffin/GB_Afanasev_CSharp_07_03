int arrLength = 5; 
int arrMin = -99; 
int arrMax = 100; 

int[] arr = MakeArray(arrLength, arrMin, arrMax);
PrintArray(arr);
TurnArray(arr);
PrintArray(arr);

int[] MakeArray(int length, int min, int max)
{
    int[] arr = new int[length];
    for(int i = 0; i < length; i++)
    {
        arr[i] = new Random().Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] array)
{
    int len = array.Length;
    for (int i = 0; i < len; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void TurnArray(int[] array)
{
    int len = array.Length;
    for (int i = 0; i < len/2; i++)
    {
        (array[i],array[len-i-1]) = (array[len-i-1],array[i]);
    }
}

