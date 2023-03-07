int num = 0;

Console.Write("Please enter number n = ");
// num = Convert.ToInt32(Console.ReadLine()); // мой вариант
num = int.Parse(Console.ReadLine()!);

Console.WriteLine("n^2 = " + (num * num));
