// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Pow (int a, int b)
{
    int result = a;
    for (int i = 1; i < b; i ++)
    {
        result *= a;
    }
    return result;
}

Console.Write("Введите число A : ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число B : ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine($"{a} в степени {b} = {Pow(a, b)}");