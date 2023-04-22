// Задача 60 : Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Clear();

Console.Write("Введите количество строк массива : ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива : ");
int columns = int.Parse(Console.ReadLine());
Console.Write("Введите глубину массива : ");
int depth = int.Parse(Console.ReadLine());

int[,,] array = GetArray(rows, columns, depth, 10, 99);
PrintArray(array);
pr(array);


int[,,] GetArray(int a, int b, int c, int min, int max)
{
    int[,,] result = new int[a, b, c];
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            for (int k = 0; k < c; k++)
            {
                result[i, j, k] = new Random().Next(min, max + 1);
            }
        }
    }
    return result;
}

void PrintArray(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 0; k < inArray.GetLength(2); k++)
            {
                Console.Write($"{inArray[i, j, k]}  ");
            }
        }
        Console.WriteLine();
    }
}

void pr(int[,,] array)
{
    int a = array.GetLength(0);
    int b = array.GetLength(1);
    int c = array.GetLength(2);

    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            for (int k = 0; k < c; k++)
            {
                Console.Write($"{array[i, j, k]} ({i} {j} {k})");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
