// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка

// Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.

Console.Clear();

Console.Write("Введите количество строк массива : ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива : ");
int columns = int.Parse(Console.ReadLine());
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

Console.WriteLine($"Строка с наименьшей суммой элементов - {MinSumRow(array)}");

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }

    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i ++)
    {
        for (int j = 0; j < inArray.GetLength(1); j ++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

int MinSumRow (int [,] array)
{
    int minsum = 0;
    int rownum = 0;

    for (int j = 0; j < array.GetLength(1); j ++)
    {
        minsum += array[0, j];
    }

    for (int i = 1; i < array.GetLength(0); i ++)
    {
        int rowsum = 0;
        for (int j = 0; j < array.GetLength(1); j ++)
        {
            rowsum += array[i, j];
        }
        if (rowsum < minsum)
        {
            minsum = rowsum;
            rownum = i;
        }
    }
    return rownum;
}

