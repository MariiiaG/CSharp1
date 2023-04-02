// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
Console.WriteLine("Введите 5-значное число : ");
int number = int.Parse(Console.ReadLine());

if (number < 10000 || number > 99999){
    Console.WriteLine("Ошибка. Введите число заново : ");
    number = int.Parse(Console.ReadLine());
}
else if (number/10000 == number%10 && number/1000%10 ==number%100/10){
    Console.WriteLine($"Да ! Число {number} является палиндромом");
}
else Console.WriteLine($"Нет :( Число {number} не является палиндромом");