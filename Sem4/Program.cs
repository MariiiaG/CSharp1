// 24. Напишите программу, которая принимает на вход число А
// и выдаёт сумму чисел от 1 до А
// а = 5
// sum = 1 + 2 + 3 + 4 + 5

// int GetSum(int n)
// {
//     int sum = 0;
//     for (int i = 1; i <= n; i ++)
//         sum += i; // same as sum = sum + 1
//     return sum;
// }
// Console.Clear();
// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine());
// Console.WriteLine($"Сумма от 1 до {n} равна {GetSum(n)}");


// 26 Напишите программу,
//  которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// int CountNum(int n)
// {
//     int count = 0;
//     while (n > 0)
//     {
//         n /= 10; // same as n = n / 10
//         count++;
//     }
//     return count;
// }
// Console.Write("Введите число: ");
// int s = int.Parse(Console.ReadLine());
// Console.WriteLine($"Количество цифр = {CountNum(s)}");
 

// 28. Напишите программу, которая принимает на вход число N 
// и выдаёт произведение чисел от 1 до N    
// 4 --> 24
// 5 --> 120

//  int MulNumber (int n) {
//     int mul = 1;
//     for (int i = 2; i <= n; i++) // start with 2 as multiplying by 1 doesn't change the result
//         mul *= i;  // same as mul = mul * i
//     return mul;
// }
// Console.WriteLine("Введите целое число: ");
// int s = int.Parse(Console.ReadLine());
// Console.WriteLine($"Произведение чисел равно {MulNumber(s)}");


//30 Напишите программу, которая выводит массив из 8 элементов, 
//заполненный нулями и единицами в случайном порядке.
//[1,0,1,1,0,1,0,0]
// int a = new Random().Next(2, 7); выдаст числа от 2 до 6
// int b = new Random().Next(2); выдаст числа от 0 до 1
// Console.WriteLine($"a = {a},b = {b}");

// int[] GetBinaryArray (int size)
// {
//     int[] result = new int[size];
//     for (int i = 0; i < size; i ++)
//     {
//         result[i] = new Random().Next(2); // Next(2) selects numbers from 0-1
//     }
//     return result;
// }
// int[] array = GetBinaryArray(8);
// Console.WriteLine($"[{String.Join(", ", array)}]"); // String.Join joins string elements ", " with our array