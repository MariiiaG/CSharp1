// Lec4. Multi-dimensional arrays. Recursion

// string[,] table = new string[2, 5]; // новая таблица строк. 2 строки, 5 столбцов
// // table [0, 0]   table [0, 1]   table [0, 2]   table [0, 3]   table [0, 4]  обращение к индексам
// // table [1, 0]   table [1, 1]   table [1, 2]   table [1, 3]   table [1, 4]
//
// table[1, 2] = "слово"; // обращаемся к элементу в первой строке, 2 столбик и записываем его значение
//
// for (int rows = 0; rows < 2; rows++) // внешний цикл перебирает строки
// {
//     for (int columns = 0; columns < 5; columns++) // внутренний цикл перебирает столбцы
//     {
//         Console.Write($"-{table[rows, columns]}-");
//     }
//     Console.WriteLine();
// }


// int[,] matrix = new int[3, 4];
// for (int i = 0; i < matrix.GetLength(0); i++) // (0) refers to the previous line [3,4]. Zero stands for 3, number of rows
// {
//     for (int j = 0; j < matrix.GetLength(1); j++) // (1) stands for the number of columns
//     {
//         Console.Write($"{matrix[i, j]} ");
//     }
//     Console.WriteLine();
// }


// ^^ same, but made into a method :
//
// void PrintArray(int[,] matr)
// {
//  
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// int[,] matrix = new int[3, 4];
// PrintArray(matrix);



// // METHOD TO FILL IN AN ARRAY WITH RANDOM NUMBERS
// void FillArray (int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i ++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j ++)
//         {
//             matr[i, j] = new Random().Next(0, 10);
//         }
//     }
// }
//
// int[,] matrix1 = new int[3, 4];
// FillArray(matrix1);
// Console.WriteLine(); // empty line as a break between 2 arrays
// PrintArray(matrix1);



// DRAW A THUMBS UP 
//
// int[,] pic = new int[,] {
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0 },
// {0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// };

// void PrintImage(int[,] image)
// {
//     for (int i = 0; i < image.GetLength(0); i++)
//     {
//         for (int j = 0; j < image.GetLength(1); j++)
//         {
//             if(image[i, j] == 0)
//             Console.Write($" ");
//             else Console.Write($"+");
//         }
//         Console.WriteLine();
//     }
// }
// PrintImage(pic);

// //  АЛГОРИТМ ДЛЯ ЗАКРАШИВАНИЯ ЗАМКНУТОЙ ОБЛАСТИ
// void FillImage(int row, int col)
// {
//     if(pic[row, col] == 0)
//     {
//         pic[row, col] = 1;
//         FillImage(row -1, col); // метод может вызывать самого себя
//         FillImage(row, col - 1); // двигаемся налево, вверх, направо, вниз
//         FillImage(row + 1, col);
//         FillImage(row, col + 1);
//     }
// }
// PrintImage(pic);
// FillImage(13, 13); // select a random point that is inside the enclosed space
// PrintImage(pic);



// RECURSION. Функция, которая вызывает сама себя

// double Factorial(int n)  // поменяли тип данных на дабл, тк инт не справляется с такими длинными значениями
// {
//     if (n == 1) // 1! = 0   0! = 1
//         return 1;
//     else 
//         return n* Factorial(n -1);
// }
// for (int i = 1; i < 40; i ++)
// {
//     Console.WriteLine($"{i}! = {Factorial(i)}");
// }


// FIBONACCI SEQUENCE f(n) = f(n-1) + f(n-2)

// double Fibonacci (int n) // can also use int but it won't show longer numbers in full, beter use double for those
// {
//     if (n == 1 || n == 2)
//     return 1;
//     else return Fibonacci(n-1) + Fibonacci(n-2);
// }
//
// for (int i = 1; i < 40; i ++)
// {
//     Console.WriteLine($"f({i}) = {Fibonacci(i)}");
// }


