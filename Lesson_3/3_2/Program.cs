Console.WriteLine("Please enter 4 coordinates in a row: ");
Console.WriteLine(FindDistance(GetCoordinate(), GetCoordinate(), GetCoordinate(), GetCoordinate()));


int GetCoordinate()
{
    int c = int.Parse(Console.ReadLine()!);
    return c;
}

double FindDistance(int x1, int y1, int x2, int y2)
{
    return Math.Round(Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)), 2);
}
