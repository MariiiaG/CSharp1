// 26 Напишите программу,
//  которая принимает на вход число и выдаёт количество цифр в числе.

// 456 -> 3
// 78 -> 2
// 89126 -> 5
//
// int CountNum(int n)
// {
//     int count = 0;
//
//     while (n > 0)
//     {
//         n /= 10;
//         count++;
//     }
//     return count;
// }
//
// Console.Write("Введите число: ");
// int s = int.Parse(Console.ReadLine());
// Console.WriteLine($"Количество цифр = {CountNum(s)}");
 

//  int MoulNumber (int n) {
//     int moul = 1;
//     for (int i = 1; i <= n; i++)
//         moul = moul * i;
//     return moul;
// }
//
// Console.WriteLine("Введите целое число: ");
// int s = int.Parse(Console.ReadLine());
// Console.WriteLine($"Произведение чисел равно {MoulNumber(s)}");


//30 Напишите программу, которая выводит массив из 8 элементов, 
//заполненный нулями и единицами в случайном порядке.

//[1,0,1,1,0,1,0,0]
// int a = new Random().Next(2, 7);
// int b = new Random().Next(2);
// Console.WriteLine($"a = {a},b = {b}");

