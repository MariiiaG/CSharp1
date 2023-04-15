// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();
Console.WriteLine ("Введите числа через запятую : ");
string numbers = Console.ReadLine();
int[] array = GetArrayFromString(numbers);
Console.WriteLine($"[{String.Join(", ", array)}] --> {countPositive(array)}");


int[] GetArrayFromString (string stringArray)
{
    string[] nums = stringArray.Split(",");
    int[] result = new int[nums.Length]; 

    for (int i = 0; i < nums.Length; i++)
    {
        result[i] = int.Parse(nums[i]); 
    }
    return result;
}

int countPositive (int[] array)
{
    int result = 0;
    foreach (int item in array)
    {
        result += item > 0 ? 1 : 0;
    }
    return result;
}

