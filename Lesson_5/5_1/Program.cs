// Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

int[] arr = MakeArray(12, -9, 9);
PrintArray (arr);
ChangeSign(arr);
PrintArray (arr);

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

int[] ChangeSign(int[] array)
{
    for (int i = 0; i < array.Length; ++i)
    {
        array[i] = -array[i];
    }
    return array;
}