// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumDigits (int n)
{
    int result = n%10;
    while (n > 10)
    {
        n = n/10;
        int temp = n%10;
        result += temp;
    }
    return result;
}

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма цифр в числе {num} равна {SumDigits(num)}");