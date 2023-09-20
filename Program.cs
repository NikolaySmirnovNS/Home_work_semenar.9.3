// Задача 68: Напишите программу вычисления функции
// Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите значения m и n:");
        int m = Convert.ToInt32(Console.ReadLine());
        int n = Convert.ToInt32(Console.ReadLine());

        int result = CalculateAckermann(m, n);

        Console.WriteLine("Результат вычисления функции Аккермана для m = {0} и n = {1} равен {2}.", m, n, result);
    }

    static int CalculateAckermann(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (m > 0 && n == 0)
        {
            return CalculateAckermann(m - 1, 1);
        }
        else if (m > 0 && n > 0)
        {
            return CalculateAckermann(m - 1, CalculateAckermann(m, n - 1));
        }
        else
        {
            return -1; 
        }
    }
}
