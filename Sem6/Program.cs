// Задача 39. Напишите программу, которая перевернёт массив
// (последний элемент будет первым, а первый последним)

//  int[] GetArray (int size, int MinValue, int MaxValue)
// {
//     int[] result = new int[size];
//     for (int i = 0; i < size; i ++)
//     {
//         result[i] = new Random().Next(MinValue, MaxValue + 1);
//     }
//     return result;
// }
//
// void ReverseArray1 (int [] inArray) // changes the current array, as we only use the working array here
// {
//     for (int i = 0; i < inArray.Length / 2; i ++)
//     {
//         int k = inArray[i];
//         inArray[i] = inArray[inArray.Length - i - 1];
//         inArray[inArray.Length - i - 1] = k;
//     }
// }
//
// int[] ReverseArray2 (int [] inArray) // will return a new reversed array result
// {
//     int[] result = new int [inArray.Length]; // creates a new empty array
//     for (int i = 0; i < inArray.Length; i ++)
//     {
//         result[i] = inArray[inArray.Length - 1 - i]; // reverses inArray and saves it as result
//     }
//     return result;
// }
//
// Console.Clear();
//
// int [] array = GetArray(10, 0, 10);
// Console.WriteLine(String.Join(" ", array));
// Console.WriteLine(String.Join(" ", ReverseArray2(array)));
// Console.WriteLine(String.Join(" ", array));
// ReverseArray1(array);
// Console.WriteLine(String.Join(" ", array));


// Задача 40: Напишите программу, которая принимает на вход 3 числа и проверяет,
// может ли существовать треугольник со сторонами такой длины
// " Теорема о неравенстве треугольника :
// Каждая сторона треугольника меньше суммы двух других сторон

// Console.Clear();
// Console.Write("Введите стороны треугольника через запятую : ");
//
// string [] sides = Console.ReadLine().Split(',');
// int a = int.Parse(sides[0]);
// int b = int.Parse(sides[1]);
// int c = int.Parse(sides[2]);
//
// bool PossiblyTriangle (int a, int b, int c)
// {
//     return (((a + b) > c) && ((a + c) > b) && ((b + c) > a));
// }
//
// if (PossiblyTriangle(a, b, c))
// {
//     Console.WriteLine("Yes");
// }
// else
// {
//     Console.WriteLine("No");
// }


// Задача 42 : Напишите программу, которая будет преобразовывать десятичное число в двоичное

// Console.Clear ();
// int number = int.Parse(Console.ReadLine());
//
// string res = DecToNum(number, 16);
//
// Console.WriteLine($"{number} --> {res}");
//
// string DecToNum(int decNumber, int otherSystem) // универсальный метод перевода из десятичной систему в любую
// {
//     string res = ""; // пустая строка для результата
//     string nums = "0123456789ABCDEF";
//     while (decNumber > 0)
//     {
//         res = nums[decNumber % otherSystem] + res;
//         decNumber /= otherSystem;
//     }
//     return res;
// }


// Задача 44 : Не используя рекурсию, выведите первые N чисел Фибоначи.
// Первые два числа Фибоначи 0 и 1.
// Если N 7 --> 0 1 1 2 3 5 8

// int[] Fib(int n)
// {
//     int[] mas_f = new int[n];
//     mas_f[0] = 0;
//     if (n >= 2)
//     {
//         mas_f[1] = 1;
//     }
//     else
//     {
//         return mas_f;
//     }
//     for (int i = 2; i < n; i++)
//     {
//         mas_f[i] = mas_f[i - 1] + mas_f[i - 2];
//     }
//     return mas_f;
// }
//
// Console.Clear();
// Console.WriteLine("Enter N : ");
// int n = int.Parse(Console.ReadLine());
// Console.WriteLine($"[{String.Join(' ', Fib(n))}]");


// Задача 45 : Напишите программу, которая будет создавать копию заданного массива 
// с помощью поэлементного копирования 

// int[] GetArray (int size, int minValue, int maxValue)
// {
//     int[] result = new int[size];
//     for (int i = 0; i < size; i ++)
//     {
//         result[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return result;
// }
//
// int[] CopyArray (int[] inArray)
// {
//     int[] res = new int[inArray.Length];
//     for (int i = 0; i < inArray.Length; i ++)
//     {
//         res[i] = inArray[i];
//     }
//     return res;
// }
//
// Console.Clear();
// int[] array = GetArray(10, 0, 10);
// Console.WriteLine(String.Join(" ", array));
//
// int[] newArray = CopyArray(array);
// Console.WriteLine(String.Join(" ", CopyArray(newArray)));
