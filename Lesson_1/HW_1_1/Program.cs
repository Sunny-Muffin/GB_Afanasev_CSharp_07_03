// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Please enter number1 n1 = ");
int num1 = int.Parse(Console.ReadLine()!);

Console.Write("Please enter number2 n2 = ");
int num2 = int.Parse(Console.ReadLine()!);

if(num1 > num2)
{
    Console.Write("MAX number is n1 = " + num1);
}
else if(num1 < num2)
{
    Console.Write("MAX number is n2 = " + num2);
}
else
{
    Console.Write("Numbers are equal");
}
