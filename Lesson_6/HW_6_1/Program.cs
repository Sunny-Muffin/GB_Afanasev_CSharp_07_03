// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь
// Эта задача подразумевает безукоризненно точный ввод пользователем цифр через пробел (а это плохо)
// Если что-то пойдет не так - программе конец

string numbers = GetUserInput();
int[] arr = MakeIntFromString(CountNumbers(numbers), numbers);
PrintArray(arr);
Console.WriteLine($"There are {FindMoreThanZero(arr)} elements, greater, than 0");

string GetUserInput()
{
    Console.Write($"Please enter numbers, separated by SPACE: ");
    string txtInput = Console.ReadLine();
    return txtInput;
}

int CountNumbers(string input)
{
    int count = 1; // числел больше, чем пробелов на 1
    for(int i = 0; i < input.Length; i++)
    {
        if(input[i] == ' ')
        {
            count++;
        }
    }
    return count;
}

int[] MakeIntFromString(int lenght, string input)
{
    int[] array = new int[lenght];
    int j = 0;
    string num = "";
    for (int i = 0; i < input.Length; i++)
    {
        
        if (input[i] == ' ')
        {
            array[j] = int.Parse(num!);
            j++;
            num = "";
        }
        else if(i == (input.Length - 1))
        {
            num += input[i];
            array[j] = int.Parse(num!);
        }
        else
        {
            num += input[i];
        }
    }
    return array;
}

int FindMoreThanZero(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
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