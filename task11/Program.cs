﻿//Программа выводит случайное трехзначное число, и удаляет вторую цифру

Console.Clear();

int num = new Random().Next(100, 1000);
// первое число включительно, а второе нет
int a1 = num / 100;
int a3 = num % 100 % 10;
Console.WriteLine($"Вот трехзначное число {num}, а теперь это ж число без второй цифры - {a1}{a3}");