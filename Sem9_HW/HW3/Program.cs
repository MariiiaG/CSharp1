﻿// Задача 68 : Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

using System;
using static System.Console;

Clear();
WriteLine ("Введите число М : ");
int M = int.Parse(ReadLine());
WriteLine ("Введите число N : ");
int N = int.Parse(ReadLine());
WriteLine ($"A({M}, {N}) = {Ackermann(M, N)}");

int Ackermann (int num1, int num2)
{
    if (num1 == 0)
        return num2 + 1;
    if (num1 > 0 && num2 == 0)
        return Ackermann(num1 - 1, 1);
    if (num1 > 0 && num2 > 0)
        return Ackermann(num1 - 1, Ackermann(num1, num2 - 1));
    else
    {
        return -1;
    }
}