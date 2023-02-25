/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да*/

Console.Clear();
Console.WriteLine("Введите пятизначное число");
int a = int.Parse(Console.ReadLine());
int b = a / 10000;
int c = (a / 1000) % 10;
int d = (a / 10) % 10;
int e = a % 10;
if (b == e && c == d) Console.WriteLine($"Число {a} является полиндромом");
else Console.WriteLine($"Число {a} не является полиндромом");
