// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.

int[] arr = MakeArray(12, -9, 9);
PrintArray (arr);
SumPosNeg(arr);

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
void SumPosNeg(int[] arr)
{
    int pos, neg;
    pos = neg = 0;

    for (int i = 0; i < arr.Length; ++i)
    {
        if(arr[i] >= 0)
            pos += arr[i];
        else
            neg += arr[i];
    }
    Console.WriteLine(pos + " " + neg);
}

