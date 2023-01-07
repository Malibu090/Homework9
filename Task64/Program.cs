// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int EnterNumber(string str)
{
    Console.Write(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

string OutputNaturalNumbers(int n)
{
    if (n < 1)
    {
        return string.Empty;
    }
    else
    {
        return $"{n}, " + OutputNaturalNumbers(n - 1);

    }
}

int n = EnterNumber("Input number N: ");
Console.WriteLine(OutputNaturalNumbers(n));
