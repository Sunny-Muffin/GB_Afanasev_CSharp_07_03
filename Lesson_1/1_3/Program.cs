int num = 0;

Console.Write("Please enter positive integer n = ");
num = int.Parse(Console.ReadLine()!);

if (num < 0)
{
    for (int i = -num; i >= num; i--)
    {
        Console.Write(i + " ");
    }
}
else if (num > 0)
{
    for (int i = -num; i <= num; i++)
    {
        Console.Write(i + " ");
    }
}
else
{
    Console.Write("0");
}


