﻿// **Задача 14:**

// Напишите программу, которая принимает на вход число и проверяет,
// кратно ли оно одновременно 7 и 23.

// 14 -> нет
// 46 -> нет
// 161 -> да

Console.WriteLine("Введите чисо");
int num = int.Parse(Console.ReadLine());
if (num % 7 == 0 && num % 23 == 0){Console.WriteLine($"Число {num} одновременно кратно и 7, и 23");}
else {Console.WriteLine($"Число {num} не кратно 7, либо 23");}