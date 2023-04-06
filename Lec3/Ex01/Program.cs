// виды методов

// 1. Ничего не принимают, ничего не возвращают (через void)
//
// void Method1()  //создаём метод
// {
//     Console.WriteLine("Автор...");
// }
// Method1();  // вызываем метод

// 2. Что-то принимают, ничего не возвращают (через void)
//
// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// Method2("Текст сообщения");

// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i ++;
//     }
// }
// Method21("Текст", 4) // Method21(count : 4, msg : "Текст") <-- именнованные аргументы, если пишем их не по порядку

// 3. Ничего не принимают, что-то возвращают
//
// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int year = Method3(); // присваиваем полученное значение переменной year
// Console.WriteLine(year); //выводим значение

// 4. Что-то принимают, что-то возвращают
//
// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty; // создаёт пустую строку, которая будет заполнена при выполнении метода
        
//         while (i < count)
//         {
//             result = result + text;
//             i ++;
//         }
//         return result;
// }

// string res = Method4(10, "our text goes in here ");
// Console.WriteLine(res);