// 1. Напишите программу, которая принимает на вход координаты точки (Х и У),
//    причём х != 0 и У != 0 и выдаёт номер четверти плоскости, в которой находится точка

// Console.Clear();
// Console.WriteLine("Введите координаты точки Х: ");
// int x = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите координаты точки У: ");
// int y = int.Parse(Console.ReadLine());
//
// if (x > 0 && y > 0){
//     Console.WriteLine("1");
// }
// else if (y > 0 && x < 0){
//     Console.WriteLine("2");
// }
// else if (x < 0 && y < 0){
//     Console.WriteLine("3");
// }
// else if (x > 0 && y < 0){
//     Console.WriteLine("4");
// }
// else if (x == 0 || y == 0){
//     Console.WriteLine("На оси");
// }

// 2. Напишите программу, которая по заданному номеру четверти 
// показывает диапазон возможных координат в этой четверти (х и у)

// Console.Clear();
// Console.WriteLine("Введите номер четверти: ");
// int quarter = int.Parse(Console.ReadLine());
//
// if (quarter == 1){
//     Console.WriteLine("Значения х от 0 до х, значения у от 0 до у");
// }
// if (quarter == 2){
//     Console.WriteLine("Значения х от -x до 0, значения у от 0 до у");
// }
// if (quarter == 3){
//     Console.WriteLine("Значения х от -x до 0, значения у от -y до 0");
// }
// if (quarter == 4){
//     Console.WriteLine("Значения х от 0 до х, значения у от -y до 0");
// }
//
// ^^ та же задача, альтернативное решение через switch case (альтернатива if, когда
// нам известные возможные варианты значения переменной)
//
// Console.Clear();
// Console.WriteLine("Введите номер четверти: ");
// int quarter = int.Parse(Console.ReadLine());

// switch (quarter)
// {
//     case 1 :{
//         Console.WriteLine("x > 0 y > 0");
//         break;
//     }
//     case 2 :{
//         Console.WriteLine("x < 0 y > 0");
//         break;
//     }
//     case 3 :{
//         Console.WriteLine("x < 0 y < 0");
//         break;
//     }
//     case 4 :{
//         Console.WriteLine("x > 0 y < 0");
//         break;
//     }
//     default :{
//         Console.WriteLine("Введена неправильная четверть");
//         break;
//     }
// }

// 3. Напишите программу,которая принимает на входе координаты двух точек
// и на выходе даёт расстояние между точками. 
//
// Console.Clear();
// Console.WriteLine("Введите коортинаты первой точки на оси х : ");
// double x1 = double.Parse(Console.ReadLine());

// Console.WriteLine("Введите коортинаты первой точки на оси y : ");
// double y1 = double.Parse(Console.ReadLine());

// Console.WriteLine("Введите коортинаты второй точки на оси х : ");
// double x2 = double.Parse(Console.ReadLine());

// Console.WriteLine("Введите коортинаты второй точки на оси y : ");
// double y2 = double.Parse(Console.ReadLine());

// double dist = Math.Sqrt((Math.Pow(x1 - x2, 2)) + (Math.Pow(y1 - y2, 2)));
// Console.WriteLine($"distance = {dist:f3}"); //f3 ограничивает количество цифр почле запятой до 3

// 4. Напишите программу, которая на входе принимает число N и на выходе
// даёт квадраты всех чисел от 1 до N (5 -> 1, 4, 9, 16, 25)

// Console.Clear();
// Console.WriteLine("Введите число N : ");
// int N = int.Parse(Console.ReadLine());
// int i = 1;
//
// while (i <= N)
// {
//     Console.WriteLine(Math.Pow(i, 2));
//     i++;
// }

// алтьтернативное решение :
// Console.Clear();
// Console.WriteLine("Введите число N : ");
// int N = int.Parse(Console.ReadLine());
// int[] result = new int[N]; // вводим массив result
//
// for (int i = 1; i <= N; i++)
//     result[i - 1] = i * i; // i - 1 чтобы записать в индекс 0,так как мин знач i задано 1
//
// for (int i = 0; i < N; i++) // вывод массива result на экран
//     Console.Write($"{result[i]} ");

// алтьтернативное решение :
// Console.Clear();
// Console.WriteLine("Введите число N : ");
// int N = int.Parse(Console.ReadLine());
// int[] result = new int[N]; // вводим массив result
//
// for (int i = 1; i <= N; i++)
//     Console.Write($"{i * i} ");


