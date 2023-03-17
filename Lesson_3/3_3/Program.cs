PrintTable(GetNumber());

int GetNumber()
{
    Console.Write("Please enter number: ");
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

void PrintTable (int n)
{
    if(n < 0)
    {
        n = -n;
    }
    for (int i = 1; i <= n; ++i)
    {
        Console.Write($"{i*i} ");
    }
}
