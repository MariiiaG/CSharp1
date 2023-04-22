// Задача 53 : Задайте двумерный массив.
// Напишите программу, которая поменяет местами первую и последнюю строку массива.
// Например :
// 1 4 7 2          8 4 2 4
// 5 9 2 3  -->     5 9 2 3
// 8 4 2 4          1 4 7 2

using System;
using static System.Console;

// Clear();
// Write("Введите количество строк массива: ");
// int rows = int.Parse(ReadLine());
// Write("Введите количество столбцов массива: ");
// int columns = int.Parse(ReadLine());

// int[,] array = GetArray(rows, columns, 10, 100);
// PrintArray(array);
// WriteLine();
// Write("Введите строку 1: ");
// int a1 = int.Parse(ReadLine());
// Write("Введите строку 2: ");
// int b1 = int.Parse(ReadLine());
// ChangeRows(array, a1, b1);
// PrintArray(array);


// int[,] GetArray(int m, int n, int min, int max)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(min, max + 1);
//         }

//     }
//     return result;
// }

// void PrintArray(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Write($"{inArray[i, j]} ");
//         }
//         WriteLine();
//     }
// }

// void ChangeRows(int[,] inArray, int a, int b)
// {
//     for (int i = 0; i < inArray.GetLength(1); i++)
//     {
//         int k = inArray[a - 1, i]; // a-1 чтобы следовать нумерации пользователя ( с 1)
//         inArray[a - 1, i] = inArray[b - 1, i];
//         inArray[b - 1, i] = k;
//     }
// }


// Задача 55 : Задайте двумерный массив.
// Напишите программу, которая заменяет строки на столбцы.
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// В итоге получается вот такой массив:
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7

// Clear();
// Write("Введите количество строк массива: ");
// int rows = int.Parse(ReadLine());
// Write("Введите количество столбцов массива: ");
// int columns = int.Parse(ReadLine());

// int[,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);
// WriteLine();
// PrintArray(ChangeArray1(array));
// WriteLine();
// PrintArray(array);
// WriteLine();
// ChangeArray2(array);
// PrintArray(array);

// int[,] GetArray(int m, int n, int min, int max)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(min, max + 1);
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Write($"{inArray[i, j]} ");
//         }
//         WriteLine();
//     }
// }

// int[,] ChangeArray1(int[,] array)
// {
//     int[,] result = new int [array.GetLength(1), array.GetLength(0)]; // changes will be saved in a new array result
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             result[j, i] = array[i, j];
//         }
//     }
//     return result;
// }

// void ChangeArray2(int[,] array) // will change the current array
// {
//     if (array.GetLength(0) != array.GetLength(1))
//     {
//         WriteLine("В данной матрице нельзя заменить элементы!");
//         return;
//     }
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = i; j < array.GetLength(1); j++)
//         {
//             int k = array[j, i];
//             array[j, i] = array[i, j];
//             array[i, j] = k;
//         }
//     }
// }

// Задача 57 : Составить частотный словарь элементов 
// двумерного массива. Частотный словарь содержит информацию о том,
//  сколько раз встречается элемент входных данных.
// { 1, 9, 9, 0, 2, 8, 0, 9 }
// 0 встречается 2 раза
// 1 встречается 1 раз
// 2 встречается 1 раз
// 8 встречается 1 раз
// 9 встречается 3 раза

// 1, 2, 3,4, 6, 1, 2, 1, 6
// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза


// Clear();
// Write("Введите количество строк массива: ");
// int rows = int.Parse(ReadLine());
// Write("Введите количество столбцов массива: ");
// int columns = int.Parse(ReadLine());
// int[,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);
// WriteLine();
// int[] rowAr = GetRowArray(array);
// SortArray(rowAr);
// WriteLine(String.Join(" ", rowAr));
// PrintData(rowAr);

// int[,] GetArray(int m, int n, int min, int max)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(min, max + 1);
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Write($"{inArray[i, j]} ");
//         }
//         WriteLine();
//     }
// }

// int[] GetRowArray(int[,] inArray)
// {
//     int[] result = new int[inArray.GetLength(0) * inArray.GetLength(1)];
//     int index = 0;
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             result[index] = inArray[i, j];
//             index++;
//         }
//     }
//     return result;
// }

// void SortArray(int[] inArray)
// {
//     for (int i = 0; i < inArray.Length; i++)
//     {
//         for (int j = i + 1; j < inArray.Length; j++)
//         {
//             if (inArray[i] > inArray[j])
//             {
//                 int k = inArray[i];
//                 inArray[i] = inArray[j];
//                 inArray[j] = k;
//             }
//         }
//     }
// }


// void PrintData(int[] inArray)
// {
//     int el = inArray[0];
//     int count = 1; // считает количество подряд идущих элементов
//     for (int i = 1; i < inArray.Length; i++)
//     {
//         if (inArray[i] != el)
//         {
//             WriteLine($"{el} встречается {count}");
//             el = inArray[i];
//             count = 1;
//         }
//         else
//         {
//             count++;
//         }
//     }
//     WriteLine($"{el} встречается {count}");
// }


// Задача 59: Из двумерного массива целых чисел удалить строку и столбец,
//  на пересечении которых расположен наименьший элемент.

