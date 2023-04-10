// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


 int[] GetArray (int size, int MinValue, int MaxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i ++)
    {
        result[i] = new Random().Next(MinValue, MaxValue + 1);
    }
    return result;
}

int CountEven (int [] array)
{
    int count = 0;
    foreach (int item in array)
    {
        if  (item % 2 == 0)
        count ++;
    }
    return count;
}

Console.Clear();
int [] myArray = GetArray(4, 100, 1000);
Console.WriteLine($"[{String.Join(", ", myArray)}] --> {CountEven(myArray)}");