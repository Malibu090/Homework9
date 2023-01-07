// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int OutputSum(int a, int b)
{
    int sum = 0;
    if (b == a)
    {
        return sum += a;
    }
    else
    {
        return sum += b + OutputSum(a, b - 1);
    }
}

int EnterNumber(string str)
{
    Console.Write(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int m = EnterNumber("Input number M: ");
int n = EnterNumber("Input number N: ");

if (m > n)
{
    Console.WriteLine("There is no interval from M to N");
}
else
{
    Console.WriteLine($"The sum of the numbers in the range from {m} to {n} is equal to {OutputSum(m, n)}");
}
