// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] GetArray(int size, int MinValue, int MaxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(MinValue, MaxValue + 1);
    }
    return result;
}

int FindMin(int[] array)
{   
    int i, min, n;
    n = array.Length;
    min = array[0];
    for (i = 1; i < n; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}

int FindMax(int[] array)
{   
    int i, max, n;
    n = array.Length;
    max = array[0];
    for (i = 1; i < n; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}

Console.Clear();
int[] startArray = GetArray(5, 0, 100);
Console.WriteLine($"[{String.Join(", ", startArray)}]");
Console.WriteLine($"{FindMax(startArray)}-{FindMin(startArray)} = {FindMax(startArray) - FindMin(startArray)}");

