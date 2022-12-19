//Задайте значение N. Напишите программу, 
//которая выведет все натуральные числа в 
//промежутке от N до 1. Выполнить с помощью рекурсии.

using System;
using static System.Console;

WriteLine("Введите число:");
int n = int.Parse(ReadLine());

void Rec (int n)
{
    if (n == 0) return;
    Write("{0,4}", n);
    Rec (n - 1);
}

Rec(n);
WriteLine();
