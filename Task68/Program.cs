// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int OutputAckermanFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if ((m > 0) && (n == 0))
    {
        return OutputAckermanFunction(m - 1, 1);
    }
    else if ((m > 0) && (n > 0))
    {
        return OutputAckermanFunction(m - 1, OutputAckermanFunction(m, n - 1));
    }
    else
    {
        return n + 1;
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

Console.WriteLine($"the Ackerman function for {m} and {n} is equal to {OutputAckermanFunction(m, n)}");
