// 1. из рандомного 3-значного число выбросить вторую цифру(ex. 294 --> 24)
// 
// Console.Clear();
// int num = new Random().Next(100, 1000);
// int result = (num / 100) * 10 + num % 10;
// Console.WriteLine($"{num} --> {result}"); // a better way, as it gives a single number as a result. So we can work with it further
// Console.WriteLine($"{num} --> {num/100}{num%10}"); // will get two separate numbers as a result

// 2.напишите программу, кот принимает на входе 2 числа и определяет, является ли второе число кратным первому
// 34, 5 --> не кратно, остаток 4
// 16, 4 --> кратно 
//
// Console.Clear();
// Console.Write("Введите первое число: ");
// int num1 = int.Parse(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int num2 =int.Parse(Console.ReadLine());
// if (num1 % num2 == 0)
// {
//     Console.WriteLine($"Число {num1} кратно числу {num2}");
// }
// else
// {
//     Console.WriteLine($"Не кратно, остаток {num1 % num2}");
// }

// 3. Напишите программу, которая на вход принимает число и проверяет, кратно ли оно 7 и 23 одновременно
//
// Console.Clear();
// Console.WriteLine("Введите число: ");
// int number = int.Parse(Console.ReadLine());
// if (number % 7 == 0 && number % 23 == 0){
//     Console.WriteLine($"Число {number} кратно 7 и 23 одновременно");
// }
// else{
//     Console.WriteLine("Не кратно");
// }

// 4. Напишите программу, которая на вход принимает два числа и проверяет, является ли одно 
// число квадратом другого
//
// Console.Clear();
// Console.Write("Введите число a: ");
// int a = int.Parse(Console.ReadLine());
// Console.Write("Введите число b: ");
// int b =int.Parse(Console.ReadLine());
// if (Math.Pow(a, 2) == b || b * b == a){
//     Console.WriteLine("Yes");
// }
// else{
//     Console.WriteLine("No");
// }

