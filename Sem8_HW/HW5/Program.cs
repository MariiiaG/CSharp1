// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

using System;
using static System.Console;

Clear();
WriteLine("Введите длину массива (= кол-во строк и столбцов) : ");
int size = int.Parse(ReadLine());

int[,] array = SpiralArray(size);
PrintArray(array);


void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j]} ");
        }
        WriteLine();
    }
}

int[,] SpiralArray(int size)
{
    int[,] result = new int[size, size];
    int i = 0;
    int j = 0;
    int num = 1;

    while (size != 0)
    {
        int k = 0;
        do
        {
            result[i, j++] = num ++;
        }
        while (++k < size - 1);
        for (k = 0; k < size - 1; k++)
        {
            result[i++, j] = num ++;
        }
        for (k = 0; k < size - 1; k++)
        {
            result[i, j--] = num ++;
        }
        for (k = 0; k < size - 1; k ++)
        {
            result[i--, j] = num ++;
        }
        ++i;
        ++j;
        if (size < 2)
        {
            size = 0;
        }
        else
        {
            size -= 2;
        }

    }
    return result;
}