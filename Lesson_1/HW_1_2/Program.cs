// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

int[] numbers = {0,0,0};
int length = numbers.Length;

for (int i = 0; i < length; i++)
{
    Console.Write($"Please enter number{i+1} n{i+1} = ");
    numbers[i] = int.Parse(Console.ReadLine()!);
}

int max = numbers[0];

for (int j = 1; j < length; j++)
{
    if (numbers[j] > max)
    {
        max = numbers[j];
    }
}

Console.WriteLine("max = " + max);
