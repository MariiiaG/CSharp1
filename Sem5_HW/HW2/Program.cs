// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] GetArray (int size, int MinValue, int MaxValue)
{
    int [] result = new int[size];
    for (int i = 0; i < size; i ++)
    {
        result[i] = new Random().Next(MinValue, MaxValue + 1);
    }
    return result;
}

int SumOddElements (int [] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
        sum = sum + array[i];
    }
    return sum;
}

Console.Clear();
int [] myArray = GetArray(4, 0, 99);
Console.WriteLine($"[{String.Join(", ", myArray)}] --> {SumOddElements(myArray)}");