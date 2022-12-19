//Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов 
//в промежутке от M до N.

using System;
using static System.Console;

WriteLine("Введите число M:");
int M = int.Parse(ReadLine());

WriteLine("Введите число N:");
int N = int.Parse(ReadLine());

void NumSum (int M, int N, int sum)
{
    if (M > N) 
    {
        WriteLine($"Сумма чисел в промежутке от M до N: {sum}"); 
        return;
    }
    sum = sum + (M++);
    NumSum(M, N, sum);
}

NumSum(M, N, 0);