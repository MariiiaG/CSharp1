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

// Clear();
// Write("Введите число M : ");
// int M = int.Parse(ReadLine());
// Write("Введите число N : ");
// int N = int.Parse(ReadLine());
// // NumMtoN(M, N); // for void solution
// Write(NumMtoN(M, N)); // for string solution

// // void NumMtoN (int i, int numN)
// // {
// //     if (i <= numN)
// //     {
// //         Write(i + ", ");
// //         i ++;
// //         NumMtoN(i, numN);
// //     }
// // }

// string NumMtoN (int numM, int numN)
// {
//     if (numM == numN)
//     {
//         return numM.ToString();
//     }
//     return numM + ", " + NumMtoN(++ numM, numN);
// }


// Задача 67 : Напишите программу, которая будет принимать на вход число 
// и возвращать сумму его цифр
// 453 --> 12
// 45 --> 9

// Clear();
// Write("Введите число N : ");
// int N = int.Parse(ReadLine());

// WriteLine($"{SumNumbers(N)}");

// int SumNumbers (int num)
// {
//     if (num == 0)
//         return 0;
//     return (num % 10 + SumNumbers(num / 10));
// }


// Задача 69 : Напишите программу, которая на вход принимает два числа А и В, 
// и возводит А в целую степень В с помощью рекурсии
// A = 3; B = 5 --> 243
// A = 2; B = 3 --> 8

// Clear();
// Write("Введите число A : ");
// int num = int.Parse(ReadLine());
// Write("Введите число B : ");
// int pow = int.Parse(ReadLine());

// WriteLine($"Число {num} в степени {pow} = {AtoPowB(num, pow)}");

// int AtoPowB (int num, int pow)
// {
//     if (pow == 0)
//         return 1;
//     return AtoPowB(num, --pow) * num;
// }