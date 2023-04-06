// Loops. For. While.

// string Method4(int count, string text)
// {
//    string result = String.Empty;
//    for (int i = 0; i < count; i ++)  // see Lec3/Ex01 for the same code but using 'while'
//    {
//         result = result + text;
//    }
//    return result;
// }
// string res = Method4(10, "our text goes in here ");
// Console.WriteLine(res);



// Nested loops
// multiplication table

// for (int i = 2; i <= 10; i ++)
// {
//     for (int j = 2; j <= 10; j ++)
//     {
//         Console.WriteLine($"{i} x {j} = {i * j}");
//     }
//     Console.WriteLine(); // an empty line to break into blocks of numbers
// }


// Дан текст. В тексте нужно заменить все пробелы чёрточками,
// маленькие буквы "к" заменить большими "К", а большие "С" на маленькие "с"

// string text = "— Я думаю, — сказал князь, улыбаясь, — что, "
// + "ежели бы вас послали вместо нашего милого Винценгероде, "
// + "вы бы взяли приступом согласие прусского короля. "
// + "Вы так красноречивы. Вы дадите мне чаю?";
//
// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;
//     int length = text.Length; 
//     for (int i = 0; i < length; i ++)
//     {
//         if (text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }
//
//     return result;
// }
// string newText = Replace(text, ' ', '|');
// Console.WriteLine(newText);
// Console.WriteLine();
//
// newText = Replace(newText, 'к', 'К');  //уже не надо указывать тип данных в начале, т.к. обращаемчся к уже 
// Console.WriteLine(newText);             // существующей переменной newText
// Console.WriteLine();
//
// newText = Replace(newText, 'с', 'S');
// Console.WriteLine(newText);
// Console.WriteLine();


// Отсортировать элементы массива по возрастанию 

// int [] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};
// void PrintArray (int[] array) // a method to print the array contents in output
// {
//     int count = array.Length;
//     for (int i = 0; i < count; i ++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine(); // an empty line 
// }

// void SelectionMinMax(int[] array) // a method to sort the numbers in our array ASC
// {
//     for (int i = 0; i < array.Length - 1; i ++) // Length -1 because in line 82 theres j = i+1
//     {
//         int minPosition = i;
//         for (int j = i + 1; j < array.Length; j ++) // j=i+1 because the first element has already been sorted
//         {
//             if (array[j] < array[minPosition]) minPosition = j;
//         }
//         int temp = array[i]; //temporary variable to swap 
//         array[i] = array[minPosition];
//         array[minPosition] = temp;
//     }
// }
// PrintArray(arr);
//
// SelectionMinMax(arr);
// PrintArray(arr);


// void SelectionMaxMin(int[] array) // a method to sort the numbers in our array DESC
// {
//     for (int i = 0; i < array.Length - 1; i ++) // Length -1 because in line 82 theres j = i+1
//     {
//         int maxPosition = i;
//         for (int j = i + 1; j < array.Length; j ++) // j=i+1 because the first element has already been sorted
//         {
//             if (array[j] > array[maxPosition]) maxPosition = j;
//         }
//         int temp = array[i]; //temporary variable to swap 
//         array[i] = array[maxPosition];
//         array[maxPosition] = temp;
//     }
// }
// PrintArray(arr);
//
// SelectionMaxMin(arr);
// PrintArray(arr);