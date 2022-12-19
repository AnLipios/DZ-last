//Напишите программу вычисления функции 
//Аккермана с помощью рекурсии. Даны два 
//неотрицательных числа m и n.

using System;
using static System.Console;
Write("Введите число M: ");
int m = int.Parse(ReadLine());

Write("Введите число N: ");
int n = int.Parse(ReadLine());

AkkerFunc(m,n);

void AkkerFunc(int m, int n)
{
    Write(Akkerman(m, n)); 
}

int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}
WriteLine();