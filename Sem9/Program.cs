// Задача 63 : Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от 1 до N.
// N = 5 --> "1, 2, 3, 4, 5"
// N = 8 --> "1, 2, 3, 4, 5, 6, 7, 8"

using System;
using static System.Console;

// Clear();
// Write("Введите число N : ");
// int N = int.Parse(ReadLine());
// Num1toN(N, 1);

// void Num1toN (int numN, int i)
// {
//     if (i <= numN)
//     {
//         Write(i + " ");
//         i ++;
//         Num1toN(numN, i);
//     }
// }

// Задача 65 : Задайте значение M и N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от М до N.
// M = 1; N = 5 --> "1, 2, 3, 4, 5"
// M = 4; N = 8 --> "4, 5, 6, 7, 8"

Clear();
Write("Введите число M : ");
int M = int.Parse(ReadLine());
Write("Введите число N : ");
int N = int.Parse(ReadLine());
// NumMtoN(M, N); // for void solution
Write(NumMtoN(M, N)); // for string solution

// void NumMtoN (int i, int numN)
// {
//     if (i <= numN)
//     {
//         Write(i + ", ");
//         i ++;
//         NumMtoN(i, numN);
//     }
// }

string NumMtoN (int numM, int numN)
{
    if (numM == numN)
    {
        return numM.ToString();
    }
    return numM + ", " + NumMtoN(++ numM, numN);
}