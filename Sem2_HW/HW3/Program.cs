// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.WriteLine("Введите номер дня недели: ");
int day = int.Parse(Console.ReadLine());
while (day > 7 || day < 1){
    Console.WriteLine("Ошибка, введите заново: ");
    day = int.Parse(Console.ReadLine());
}
if (day == 1 || day == 2 || day == 3 || day == 4 || day == 5){
    Console.WriteLine("Не выходной");
}
else {
    Console.WriteLine("Да, выходной");
}