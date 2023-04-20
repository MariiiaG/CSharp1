// Задача 31. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива

// int[] GetRandomArray (int size, int MinValue, int MaxValue)
// {
//     int[] result = new int[size];
//     for (int i = 0; i < size; i ++)
//     {
//         result[i] = new Random().Next(MinValue, MaxValue + 1);
//     }
//     return result;
// }
//
// int[] SumPosNeg(int[] array)
// {
//     int[] result = new int[2];
//     foreach (int el in array)
//     {
//         result[0] += el > 0 ? el : 0; //  if el>0 then add value of el to the array , else 0
//         result[1] += el < 0 ? el : 0; 
//     }
//     return result;
// }
// int [] array = GetRandomArray(12, -9, 9);
// Console.WriteLine(String.Join(", ", array));
// int [] r = SumPosNeg(array);
// Console.WriteLine($"Positive sum = {r[0]}, negative sum = {r[1]}");
// Console.WriteLine($"[{String.Join(", ", array)}]");



// Задача 32: Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]  String.Join(", ", array)*/

// int[] array = { -4, -8, 8, 2 };
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = array[i] * -1;
// }
// Console.Write(String.Join(", ", array));



// Задача 33:**Задайте массив.Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив[6, 7, 19, 345, 3]->нет
// 3; массив[6, 7, 19, 345, 3]->да*/

// bool FindElement(int [] array, int el)
// {
//     foreach (var item in array) // var работает для любых типов данных
//     {
//         if (el == item) 
//         return true;
//     }
//     return false;
// }
//
// int[] GetArrayFromString (string stringArray)
// {
//     string[] nums = stringArray.Split(" "); // creates a string array from a string of numbers divided by " "
//     int[] res = new int[nums.Length]; // creates an int array
//
//     for (int i = 0; i < nums.Length; i++)
//     {
//         res[i] = int.Parse(nums[i]); // convert items from string array into an int array
//     }
//     return res;
// }
// Console.Clear();
// Console.Write("Введите элементы массива через пробел : ");
// string elements = Console.ReadLine();
// int[] baseArray = GetArrayFromString(elements);
// Console.Write("Введите число : ");
// int n = int.Parse(Console.ReadLine());
// if (FindElement(baseArray, n))
// {
//     Console.WriteLine("Да");
// }
// else
// {
//     Console.WriteLine("Нет"); 
// }

/// int[] array = {6, 7, 19, 345, 3};  //alternative soulution from seminar
/// int temp=3;
/// int constMe=0;
/// foreach (int i in array){
///     if (i==temp){
///         constMe=1;
///     }else{
///         constMe=0;
///     }    
/// }
/// Console.WriteLine(constMe>0?"Да":"Нет");



// Задача 35: Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2]-> 0
// [10, 11, 12, 13, 14]-> 5


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
// int CountElem (int [] array, int bottom, int top)
// {
//     int count = 0;
//     foreach (int item in array)
//     {
//         if  (item >= bottom && item <= top)
//         count ++;
//     }
//     return count;
// }
//
// Console.Clear();
// int [] startArray = GetArray(123, 0, 200);
// Console.WriteLine(String.Join(" ", startArray));
// Console.WriteLine($"Amount of elements between [10; 99] equals to {CountElem(startArray, 10, 99)}");


