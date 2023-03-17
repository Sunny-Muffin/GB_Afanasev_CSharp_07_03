// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве

int[] point1 = new int[3];
int[] point2 = new int[3];
Console.WriteLine("Please enter coordinates of 1st point");
point1 = GetCoordinates(point1);
Console.WriteLine("Please enter coordinates of 2nd point");
point2 = GetCoordinates(point2);

Console.WriteLine($"The distance between 2 points is: {Math.Round(CountDistance(point1, point2), 2)}");

int[] GetCoordinates(int[] arr)
{
    int arrLength = arr.Length;
    for (int i = 0; i < arrLength; ++i)
    {
        string coord;
        if(i == 0) coord = "X";
        else if(i == 1) coord = "Y";
        else coord = "Z";

        Console.Write($"{coord}: ");
        arr[i] = int.Parse(Console.ReadLine()!);
    }
    return arr;
}

double CountDistance(int[]dot1, int[]dot2)
{
    return Math.Sqrt((dot2[0] - dot1[0]) * (dot2[0] - dot1[0]) + 
                     (dot2[1] - dot1[1]) * (dot2[1] - dot1[1]) + 
                     (dot2[2] - dot1[2]) * (dot2[2] - dot1[2]));
}