// Задача 66 : Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

using System;
using static System.Console;

Clear();
WriteLine ("Введите число М : ");
int M = int.Parse(ReadLine());
WriteLine ("Введите число N : ");
int N = int.Parse(ReadLine());
WriteLine ($"Сумма натуральных чисел от {M} до {N} = {SumNumMtoN(M, N)}");

int SumNumMtoN (int num1, int num2)
{
    if (num1 == num2)
        return num1;
    return num1 + SumNumMtoN (++num1, num2);
}
